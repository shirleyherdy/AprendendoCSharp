using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimindo números de 0 a 10 com For");
            for (int contador = 0; contador <= 10; contador++)
                Console.WriteLine(contador);

            Console.ReadLine();
        }
    }
}
