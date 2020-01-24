using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;


            num1 = 0;
            num2 = 1;
           

            int ini, fin;
            ini = 1;
            Console.WriteLine("introduscas cuantos numeros de fibonachi quieres");
            fin = Convert.ToInt32(Console.ReadLine());

            Console.Write(num1 + ",");

            do
            {

                num1 = num1 + num2;
                num2 = num1 - num2;

                Console.Write(num1 + ",");


                ini++;
                
            }

            while (ini <= fin);
           

            Console.ReadKey();




            
        }
    }
}
