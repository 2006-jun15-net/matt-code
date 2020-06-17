using System;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The Collatz conjecture, if a number is odd, multiply by 3 and add one
            (making it even) if a number is even, divide by two.*/

            Console.WriteLine("Enter a whole number:\n");

            //accept user input to test
            int testVar = int.Parse(Console.ReadLine());

            //test with if/else statements in a while loop
            while(testVar > 1)
            {
                if(testVar % 2 == 0)
                {
                    testVar/=2;
                }
                else
                {
                    testVar = (3 * testVar) + 1;
                }
                Console.WriteLine("Result: " + testVar);
            }
        }
    }
}
