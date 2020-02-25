import InsertionSort from './InsertionSort'

describe('sort()', () => {
    const iSort = new InsertionSort()

    it('sorts the array', () => {
        const inputData = [5, 3, 6, 9, 10, 45, 23, 12, 4, 2]
        const expectedData = [2, 3, 4, 5, 6, 9, 10, 12, 23, 45]
        const outputData = iSort.sort(inputData);
        expect(outputData).toEqual(expectedData)
    })

    it('sorts the array', () => {
        const inputData = [20, 2, 10, 6, 52, 31, 0, 45, 79, 40]
        const expectedData = [0, 2, 6, 10, 20, 31, 40, 45, 52, 79]
        const outputData = iSort.sort(inputData);
        expect(outputData).toEqual(expectedData)
    })

    it('sorts the array', () => {
        const inputData = [90, -20, 8, 11, 3]
        const expectedData = [-20, 3, 8, 11, 90]
        const outputData = iSort.sort(inputData);
        expect(outputData).toEqual(expectedData)
    })

    it('sorts the array', () => {
        const inputData = [33, 22, 11, 21, 55, 32, 3, 4]
        const expectedData = [3, 4, 11, 21, 22, 32, 33, 55]
        const outputData = iSort.sort(inputData);
        expect(outputData).toEqual(expectedData)
    })

    it('sorts the array, reversed', () => {
        const inputData = [11, 22, 33, 44, 55, 66, 77]
        const expectedData = [77, 66, 55, 44, 33, 22, 11]
        const outputData = iSort.sort(inputData, true);
        expect(outputData).toEqual(expectedData)
    })
})
