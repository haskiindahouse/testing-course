from mock_examples.main import slow_dataset


def test_mocking_class_method(mocker):
    expected = 'xyz'

    def mock_load(self):
        return 'xyz'

    mocker.patch(
        'mock_examples.main.Dataset.load_data',
        mock_load
    )
    actual = slow_dataset()
    assert expected == actual
