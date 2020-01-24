using System;

namespace conteo_asia_tras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            num2 = 0;
            num3 = 0;
            Console.WriteLine("introdusca el numero al cual quieres que retroseda ");
            num1 = Int32.Parse(Console.ReadLine());
            num3 = num1;
            while (num2 <= num1)
            {
                Console.Write("{0}," ,num3);
                num2++;
                num3--;

            }

            Console.ReadKey();

        }
    }
}
