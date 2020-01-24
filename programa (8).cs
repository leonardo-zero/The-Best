using System;

namespace bucle_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int ini, fin ;
            int suma;

            suma = 0;
            ini = 1;

            Console.Write(" colocar cuantas sumas quieres realisar : ");
            fin = Int32.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("este es la operacion numero #{0} ",ini );

                Console.Write("introdusca el primer numero : ");
                num1 = Int32.Parse(Console.ReadLine());

                Console.Write("introdusca el segundo numero : ");
                num2 = Int32.Parse(Console.ReadLine());

                suma = num1 + num2;

                Console.WriteLine("este es el resultado de la suma : {0} ", suma );

                ini++;

                Console.WriteLine("");

            } while (ini <= fin);

            Console.ReadKey();      
        }
    }
}
