import sys


def sort(inputArray, reversed=False):
    for i in range(1, len(inputArray)):
        for j in range(i-1, -1, -1):
            key = inputArray[j+1]
            if((not reversed and inputArray[j+1] < inputArray[j]) or (reversed and inputArray[j+1] > inputArray[j])):
                inputArray[j + 1] = inputArray[j]
                inputArray[j] = key
            else:
                break
    return inputArray


# sort([5, 3, 6, 9, 10, 45, 23, 12, 4, 2])

if __name__ == "__main__":
    arr = sys.argv[1].split(',')
    reverse = sys.argv[2]
    numArr = []
    for num in arr:
        numArr.append(int(num))
    print(sort(numArr, reverse == "True"))
