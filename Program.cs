﻿namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        Challenge_one one = new Challenge_one();
        Challenge_two two = new Challenge_two();
        Challenge_three three = new Challenge_three();

        one.PrintNumbers();
        one.PrintStrings(["hello", "there", "array"]);
        one.CheckIfNumberIsPositiveOrNegative(0);

        two.Fibonacci(8);
        two.GuessNumber();
        two.CheckIfNumberIsEvenOrOdd(2, 2);
        three.FizzBuzz();
        three.ReverseString("Hello");


        // validate some methods
        void ValidateRecursiveFactorial()
        {
            int n = 5;
            int expected = 120; // 5! = 120
            int result = three.RecursiveFactorial(n);

            if (result == expected)
            {
                Console.WriteLine($"Test passed: RecursiveFactorial({n}) = {expected}");
            }
            else
            {
                Console.WriteLine($"Test failed: RecursiveFactorial({n}) = {result}, expected: {expected}");
            }
        }

        ValidateRecursiveFactorial();
    }
}
