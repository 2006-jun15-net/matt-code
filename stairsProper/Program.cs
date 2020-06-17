using System;

namespace stairsProper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings are immutable; need to find a way to repeat input of char/line
            Console.WriteLine("Enter the number of steps to add.\n");

            int numOfSteps = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numOfSteps; i++)
            {
                for (int j = 1; j <=numOfSteps-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                { 
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
