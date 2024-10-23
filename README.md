# Question: How do you rotate an image by 90 degrees represented as a 2D array? JavaScript Summary

The JavaScript code provided defines a function named `rotateImage` that rotates a 2D array, which represents an image, by 90 degrees. The function takes a 2D array as an argument and calculates the length of the array, which is stored in the variable `n`. It then calculates the midpoint of the array, stored in `x`, and the last index of the array, stored in `y`. The function then uses two nested loops to iterate over the array. The outer loop iterates from the first element to the midpoint of the array, while the inner loop iterates from the current index of the outer loop to the difference between the last index and the current index of the outer loop. Within the inner loop, the function performs a series of swaps to rotate the elements of the array. The function then returns the rotated image. The script also includes a test case where it defines a 2D array `image`, calls the `rotateImage` function with `image` as the argument, and logs the result to the console.

---

# TypeScript Differences

The TypeScript version solves the problem in a similar way to the JavaScript version, but with a few key differences:

1. The TypeScript version uses a class `ImageRotator` to encapsulate the `rotateImage` function. This is a feature of TypeScript (and modern JavaScript) that allows for better organization of related functions and data.

2. The TypeScript version uses type annotations (`number[][]`) to specify that the `rotateImage` function takes a 2D array of numbers as input and returns a 2D array of numbers. This is a feature of TypeScript that is not available in JavaScript. It provides better documentation and can help catch errors.

3. The TypeScript version creates a new 2D array `rotatedImage` to store the rotated image, instead of modifying the original image in-place as the JavaScript version does. This is a more functional programming style and can help prevent bugs related to mutable state.

4. The TypeScript version uses a different algorithm to rotate the image. It iterates over each element in the original image and calculates its new position in the rotated image. This is simpler and more straightforward than the JavaScript version, which uses a more complex algorithm involving four nested loops and swapping elements in-place.

5. The TypeScript version uses the `Array.from` and `Array.fill` methods to create the new 2D array. These are modern JavaScript features that may not be available in older JavaScript environments.

---

# C++ Differences

The C++ version of the solution uses the same logic as the JavaScript version to rotate the image by 90 degrees. Both versions use nested for loops to iterate over the 2D array (image) and swap elements to achieve the rotation.

However, there are some differences due to the language features and methods used:

1. Data Structures: In JavaScript, arrays are used to represent the 2D image. In C++, `std::vector` is used instead, which is a dynamic array provided by the Standard Template Library (STL).

2. Function Parameters: In JavaScript, the image is passed by value to the function, which means a copy of the image is made. In C++, the image is passed by reference (`std::vector<std::vector<int>>& matrix`), which means the function operates directly on the original image, not a copy.

3. Printing: In JavaScript, `console.log` is used to print the image to the console. In C++, `std::cout` is used for console output. The C++ version also includes a separate `printMatrix` function to print the 2D array.

4. Main Function: In JavaScript, the script is executed from top to bottom. In C++, the `main` function serves as the entry point of the program.

5. Return Values: The JavaScript function returns the rotated image, while the C++ function modifies the image in-place and does not return anything.

6. Variable Declaration: In JavaScript, `let` is used to declare variables. In C++, `int` is used to declare integer variables.

7. Array/Vector Size: In JavaScript, the `length` property is used to get the size of the array. In C++, the `size()` method is used to get the size of the vector.

---
