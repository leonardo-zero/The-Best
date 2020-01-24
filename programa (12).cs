using System;

namespace ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma1 , suma2 , suma3;
            int ini, fin;
            ini = 1;
            suma1 = 0;
            suma2 = 0;
            suma3 = 0;

            Console.Write("introdusca cuantos numeros quieres : ");
            fin = Convert.ToInt32(Console.ReadLine());


            while(ini <= fin)
            {


                bool primo = true;

                for (int contador = ini - 1; contador > 1; contador--)
                {
                    if (ini % contador == 0)
                    {
                        primo = false;

                    }

                }

                if (primo)
                {
                    
                    suma3 = suma3 + ini;
                }



                if (ini % 2 == 0)
                {
               

                    suma2 = suma2 + ini;
                }
                else
                {

                   

                    suma1 = suma1 + ini;

                }

                ini++;

            }
            Console.WriteLine("");
            Console.WriteLine("esta es la suma de los numeros impares : " + suma1);
            Console.WriteLine("esta es la suma de los numeros pares : " + suma2);
            Console.WriteLine("esta es la suma de los numeros primos  : " + suma3);

            Console.ReadKey();  
        }
    }
}
