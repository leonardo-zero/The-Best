using System;

namespace numeros_impares__1_
{
    class Program
    {
        static void Main(string[] args)
        {

            int ini, fin;
            ini = 1;

            Console.Write("introdusca cuantos numeros impares quieres : ");
            fin = Convert.ToInt32(Console.ReadLine());


            while(ini <= fin)
            {
                if (ini % 2 == 0)
                { 

                }
                else
                {

                    Console.Write(ini+ ",");  
                }

                ini++;

            }

            Console.ReadKey();


        }
    }
}
