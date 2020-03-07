"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var InsertionSort = /** @class */ (function () {
    function InsertionSort() {
    }
    InsertionSort.prototype.sort = function (inputArray, reversed) {
        if (reversed === void 0) { reversed = false; }
        for (var i = 0; i < inputArray.length; i++) {
            var key = inputArray[i];
            var j = i - 1;
            while (((!reversed && key < inputArray[j]) || (reversed && key > inputArray[j])) && j >= 0) {
                inputArray[j + 1] = inputArray[j];
                j--;
            }
            inputArray[j + 1] = key;
        }
        return inputArray;
    };
    return InsertionSort;
}());
exports.default = InsertionSort;
