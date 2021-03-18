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
            Console.WriteLine("Executando projeto7 - condicionais");
            int idadeJoao = 15;
            int quantidadePessoas = 1;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado, pode entrar.");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos e não está acompanhado, não pode entrar");
                }
            }

            Console.WriteLine("Projeto finalizado, tecle enter para fechar");
            Console.ReadLine();

        }
    }
}
