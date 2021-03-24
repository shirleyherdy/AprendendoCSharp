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

            Console.WriteLine("Imprimindo tabuada de 0 a 10 com For");
            for (int multiplicador = 0; multiplicador <=10 ; multiplicador++)
			{               
                for (int contador = 0; contador <= 10; contador++)
                {    
                    Console.WriteLine(multiplicador + " * " + contador + " = " + contador * multiplicador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            

            Console.ReadLine();
        }
    }
}
