using System;

namespace stairs
{
    class Program
    {
        static void Main(string[] args)
        {
         //run a for loop over an array of strings
         string[] stairs = {"       #", "      ##", "     ###", "    ####", "   #####", "  ######", " #######", "########"};

         for(int i=0; i<stairs.Length;i++)
         {
             Console.WriteLine(stairs[i]);
         }
        }
    }
}
