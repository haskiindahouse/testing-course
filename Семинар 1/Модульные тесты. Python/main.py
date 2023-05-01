import unittest
from parameterized import parameterized


def cleanup_method(msg):
    print("cleanup_method: " + msg)


def setUpModule():
    print("in setUpModule")


def tearDownModule():
    print("in tearDownModule")


class BasicTestCase1(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        print("in setUpClass")

    @classmethod
    def tearDownClass(cls):
        print("in tearDownClass")

    def setUp(self):
        print("\nin setUp")

    def tearDown(self):
        print("in tearDown")

    def test_something(self):
        print("in BasicTestCase1.test_something")
        self.addCleanup(cleanup_method, "first addCleanup in test_something")
        self.addCleanup(cleanup_method, "second addCleanup in test_something")
        self.assertTrue(True)


class BasicTestCase2(unittest.TestCase):
    def test_something_else(self):
        print("\nin BasicTestCase2.test_something_else")
        self.assertTrue(True)


def broken_function():
    raise Exception('This is broken')


class MyTestCase(unittest.TestCase):
    def test(self):
        with self.assertRaises(Exception) as context:
            broken_function()

        self.assertTrue('This is broken' in context.exception)


class TestSequence(unittest.TestCase):
    @parameterized.expand([
        ["foo", "a", "a",],
        ["bar", "a", "b"],
        ["lee", "b", "b"],
    ])
    def test_sequence(self, name, a, b):
        self.assertEqual(a,b)
