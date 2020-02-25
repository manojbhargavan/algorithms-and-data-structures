# Insertion Sort

Insertion sort is an efficient algorithm for sorting a small number of elements. Insertion sort works the way many people sort a hand of playing cards. We start with an empty left hand and the cards face down on the table. We then remove one card at a time from the table and insert it into the correct position in the left hand. To find the correct position for a card, We compare it with each of the cards already in the hand, from right to left. At all times, the cards held in the left hand are sorted, and these cards were originally the top cards of the pile on the table.

* Given the input array/list we create another empty array/list to store the sorted
* We start but looping through each element in input array/list from left to right and inserting it to the appropriate position in the output array/list by comparing the element picked 

## Code Samples
These are simple minimal example without any/minimal error handling. Written using vscode on windows.
* [C#](./c-sharp): A Simple console application, Sorting algorithm implemented as extension method. You can either run the console application or the XUnit tests in the test project.
* [Python](./python): You can run the directly from command line like so, it will print out the results

    python .\insertion_sort.py 5,3,6,9,10,45,23,12,-2,4,2 True 

    python .\insertion_sort.py 5,3,6,9,10,45,23,12,-2,4,2 False

    Or import the same, you may refer to the test file for more information. 

    To run the test run: pytest .\insertion_sort_test.py
* [TypeScript/JavaScript](./typescript)
    Install all the required packages: npm install
    To run the test: npm test

    Javascript is complied by tsc into ./js folder, please look at the tsconfig.json for details.
* Rust