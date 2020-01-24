using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_01_
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int ini, fin;
            ini = 1;

            Console.Write("introdusca la cantidad de comparaciones que quieres : ");
            fin = Convert.ToInt32(Console.ReadLine());

           
            while (ini <= fin)
            {

                Console.Write("introdusca los 5 numero que quieres invertir : ");
                nombre = Console.ReadLine();

                StringBuilder nombre2 = new StringBuilder(nombre);
                StringBuilder nombre3 = new StringBuilder(nombre);

                nombre3[0] = nombre2[4];
                nombre3[1] = nombre2[3];
                nombre3[2] = nombre2[2];
                nombre3[3] = nombre2[1];
                nombre3[4] = nombre2[0];

                ini++;


                Console.WriteLine("estos son los numeros invertidos : " + nombre3);
            }
            



            Console.ReadKey();
        }
    }
}
