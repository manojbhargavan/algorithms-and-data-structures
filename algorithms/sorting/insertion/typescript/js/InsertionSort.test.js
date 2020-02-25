"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
var InsertionSort_1 = __importDefault(require("./InsertionSort"));
describe('sort()', function () {
    var iSort = new InsertionSort_1.default();
    it('sorts the array', function () {
        var inputData = [5, 3, 6, 9, 10, 45, 23, 12, 4, 2];
        var expectedData = [2, 3, 4, 5, 6, 9, 10, 12, 23, 45];
        var outputData = iSort.sort(inputData);
        expect(outputData).toEqual(expectedData);
    });
    it('sorts the array', function () {
        var inputData = [20, 2, 10, 6, 52, 31, 0, 45, 79, 40];
        var expectedData = [0, 2, 6, 10, 20, 31, 40, 45, 52, 79];
        var outputData = iSort.sort(inputData);
        expect(outputData).toEqual(expectedData);
    });
    it('sorts the array', function () {
        var inputData = [90, -20, 8, 11, 3];
        var expectedData = [-20, 3, 8, 11, 90];
        var outputData = iSort.sort(inputData);
        expect(outputData).toEqual(expectedData);
    });
    it('sorts the array', function () {
        var inputData = [33, 22, 11, 21, 55, 32, 3, 4];
        var expectedData = [3, 4, 11, 21, 22, 32, 33, 55];
        var outputData = iSort.sort(inputData);
        expect(outputData).toEqual(expectedData);
    });
    it('sorts the array, reversed', function () {
        var inputData = [11, 22, 33, 44, 55, 66, 77];
        var expectedData = [77, 66, 55, 44, 33, 22, 11];
        var outputData = iSort.sort(inputData, true);
        expect(outputData).toEqual(expectedData);
    });
});
