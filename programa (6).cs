using System;

namespace numeros_de_bertrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, z, x , d , p;
            int cubo = 0;


            Console.WriteLine( "estos son los numeros de bestron del 1 al 500 ");

            for (i = 1; i <= 500; i++)
            {
                cubo = 0;
                z = 1;
                x = 3;
                d = i;



                while (z <= x)
                {
                    p = d % 10;
                    cubo = cubo +(p * p * p);

                    d = d / 10;
                    z++;


                }

                if (cubo == i)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();
                
        }
    }
}
