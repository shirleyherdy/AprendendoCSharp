using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - condicionais 2");
            int idadeJoao = 18;
            //int quantidadePessoas = 3;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;

            if (idadeJoao >= 18 && acompanhado == true) // ou = || e = &&
            //Os operadores lógicos devem ter no lado esquerdo e direito uma expressão booleana
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }

            Console.ReadLine();
        }
    }
}

