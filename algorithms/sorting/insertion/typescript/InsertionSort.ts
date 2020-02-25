class InsertionSort {
    sort(inputArray: number[], reversed: boolean = false): number[] {
        for (let i = 1; i < inputArray.length; i++) {
            for (let j = i - 1; j >= 0; j--) {
                if ((!reversed && inputArray[j + 1] < inputArray[j]) ||
                    (reversed && inputArray[j + 1] > inputArray[j])) {
                    let swapValue = inputArray[j + 1];
                    inputArray[j + 1] = inputArray[j];
                    inputArray[j] = swapValue;
                }
                else {
                    break;
                }
            }
        }
        return inputArray;
    }
}

export default InsertionSort