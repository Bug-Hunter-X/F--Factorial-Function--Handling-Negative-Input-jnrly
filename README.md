# F# Factorial Function: Handling Negative Input

This example demonstrates a common error in recursive functions: not handling edge cases properly.  The `factorial` function throws a `System.ArgumentException` when it encounters a negative input. This README explains the problem and provides a solution.

## Problem

The original `factorial` function does not explicitly handle negative inputs.  Recursive calls continue until a stack overflow occurs, or an exception is thrown when the function attempts to calculate the factorial of a negative number.