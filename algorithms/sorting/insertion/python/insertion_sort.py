import sys


def sort(inputArray, reversed=False):
    for i in range(1, len(inputArray)):
        key = inputArray[i]
        j = i - 1
        while(((not reversed and key < inputArray[j]) or (reversed and key > inputArray[j])) and j >= 0):
            inputArray[j+1] = inputArray[j]
            j -= 1
        inputArray[j + 1] = key
    return inputArray


# sort([5, 3, 6, 9, 10, 45, 23, 12, 4, 2])


if __name__ == "__main__":
    arr = sys.argv[1].split(',')
    reverse = sys.argv[2]
    numArr = []
    for num in arr:
        numArr.append(int(num))
    print(sort(numArr, reverse == "True"))
