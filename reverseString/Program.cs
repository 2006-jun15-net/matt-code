using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase to have reversed.\n");

            string userInput = Console.ReadLine();

            //convert input to char array
            char[] userString = userInput.ToCharArray();

            //Set empty string to hold chars in reverse order
            string reverse = String.Empty;

            //init 'i' to length of array (-1 because index values), while there's still 
            //index values, continue operation decrementing index position each iteration
            for (int i = userString.Length - 1; i >= 0; i--)
            {
                reverse += userString[i];
            }

            Console.WriteLine(reverse);

        }
    }
}