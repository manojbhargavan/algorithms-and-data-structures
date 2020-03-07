class InsertionSort {
    sort(inputArray: number[], reversed: boolean = false): number[] {

        for (let i = 0; i < inputArray.length; i++) {
            let key = inputArray[i];
            let j = i - 1
            while (((!reversed && key < inputArray[j]) || (reversed && key > inputArray[j])) && j >= 0) {
                inputArray[j + 1] = inputArray[j];
                j--;
            }
            inputArray[j + 1] = key;
        }

        return inputArray;
    }
}

export default InsertionSort