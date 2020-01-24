using System;

namespace numeros_impares__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma1;
            int ini, fin;
            ini = 1;
            suma1 = 0;
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

                    suma1 = suma1 + ini;

                }

                ini++;

            }
            Console.WriteLine("");
            Console.WriteLine("esta es la suma de los numeros impares : " + suma1);


            Console.ReadKey();


        }
    }
}
