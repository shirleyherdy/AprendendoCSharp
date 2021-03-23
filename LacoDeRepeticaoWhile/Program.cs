using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimindo números de 0 a 10 com While");

            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.ReadLine();
        }
    }
}
