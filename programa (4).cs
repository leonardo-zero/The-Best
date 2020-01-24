using System;

namespace tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int  buc1, num1, res1 , t1 ,buc2;

            t1 = 1;
            res1 = 1;
            num1 = 1;

            Console.Write("introduce la tabla que quiera multiplicar ");
            buc1 = Int32.Parse(Console.ReadLine());

            Console.Write("introduce hasta donde quieres que llegue la tabla ");
            buc2 = Int32.Parse(Console.ReadLine());

            while ( t1 <= buc2  )
            {
                res1 = num1 * buc1;

                Console.WriteLine(" {0} * {1}  = {2} ",t1,buc1 ,res1);

                num1++;
             

                t1++;

            }

            Console.ReadKey();

        
        }
    }
}
