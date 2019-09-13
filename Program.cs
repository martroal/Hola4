using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int suma;

            numeros[0] = 200;
            numeros[1] = 150;
            numeros[2] = 100;
            numeros[3] = -50;
            numeros[4] = 300;
            suma = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4];
            Console.WriteLine("Su suma es {0}", suma);
            Console.ReadKey();

        }
    }
}
