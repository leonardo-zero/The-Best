using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 0;
            int a2 = 1;
            int a3 = 0;
            int a4 = 1;

            

            while (a1 < a2) 
            {
                Console.WriteLine("    *   ");
                Console.WriteLine("   ***  ");
                Console.WriteLine("  ***** ");
                Console.WriteLine(" ******* ");
                Console.WriteLine("********* ");
                a1++;
               

            }
            while (a3 < a4)
            {
                Console.WriteLine(" ******* ");
                Console.WriteLine("  *****  ");
                Console.WriteLine("   ***  ");
                Console.WriteLine("    * ");

                a3++;

            }

            Console.ReadKey();
        }
    }
}
