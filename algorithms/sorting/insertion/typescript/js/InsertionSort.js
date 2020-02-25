"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var InsertionSort = /** @class */ (function () {
    function InsertionSort() {
    }
    InsertionSort.prototype.sort = function (inputArray, reversed) {
        if (reversed === void 0) { reversed = false; }
        for (var i = 1; i < inputArray.length; i++) {
            for (var j = i - 1; j >= 0; j--) {
                if ((!reversed && inputArray[j + 1] < inputArray[j]) ||
                    (reversed && inputArray[j + 1] > inputArray[j])) {
                    var swapValue = inputArray[j + 1];
                    inputArray[j + 1] = inputArray[j];
                    inputArray[j] = swapValue;
                }
                else {
                    break;
                }
            }
        }
        return inputArray;
    };
    return InsertionSort;
}());
exports.default = InsertionSort;
