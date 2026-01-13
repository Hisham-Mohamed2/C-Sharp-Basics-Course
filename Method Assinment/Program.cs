using System;  // System namespace allows basic functionality like Console operations

// Define a new class called MathOperations
class MathOperations
{
    // Method that accepts two integer parameters
    public void PerformMathOperation(int firstNumber, int secondNumber)
    {
        // Perform a simple math operation on the first number (e.g., multiplying by 4)
        int result = firstNumber * 4;

        // Output the second number to the screen
        Console.WriteLine("The second number is: " + secondNumber);

        // Display the result of the math operation
        Console.WriteLine("The result of doubling the first number is: " + result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance (object) of the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Calling the method with two integer parameters
        mathOps.PerformMathOperation(9, 13); 

        // Calling the method using named parameters (for better readability)
        mathOps.PerformMathOperation(firstNumber: 18, secondNumber: 24);  
    }
}
