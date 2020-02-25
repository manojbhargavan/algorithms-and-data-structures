import unittest

from insertion_sort import sort


class InsertionSortTest(unittest.TestCase):
    def test_dataset1(self):
        inputData = [5, 3, 6, 9, 10, 45, 23, 12, 4, 2]
        expectedData = [2, 3, 4, 5, 6, 9, 10, 12, 23, 45]
        self.assertEqual(sort(inputData), expectedData)

    def test_dataset2(self):
        inputData = [20, 2, 10, 6, 52, 31, 0, 45, 79, 40]
        expectedData = [0, 2, 6, 10, 20, 31, 40, 45, 52, 79]
        self.assertEqual(sort(inputData), expectedData)

    def test_dataset3(self):
        inputData = [90, -20, 8, 11, 3]
        expectedData = [-20, 3, 8, 11, 90]
        self.assertEqual(sort(inputData), expectedData)

    def test_dataset4(self):
        inputData = [33, 22, 11, 21, 55, 32, 3, 4]
        expectedData = [3, 4, 11, 21, 22, 32, 33, 55]
        self.assertEqual(sort(inputData), expectedData)

    def test_dataset5(self):
        inputData = [11, 22, 33, 44, 55, 66, 77]
        expectedData = [77, 66, 55, 44, 33, 22, 11]
        self.assertEqual(sort(inputData, True), expectedData)
