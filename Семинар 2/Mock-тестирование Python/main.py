from unittest import TestCase
from unittest import mock


class Calculator:
    def sum(self, a, b):
        return a + b


class TestCalculator(TestCase):
    @mock.patch('main.Calculator.sum', return_value=9)
    def test_sum(self, sum):
        self.assertEqual(sum(2, 3), 9)


@mock.patch('mylib.requests.post')
class MyTest(TestCase):

    def test_foo(self, post_mock):
        post_mock.side_effect = mock.mocked_post

        # Some test logic

        self.assertEqual(post_mock.call_count, 3)