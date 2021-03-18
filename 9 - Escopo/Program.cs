using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - escopo");
            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado";
            }
            else
         //   { caso eu tenha somente uma instrução no bloco, não preciso das chaves
               mensagemAdicional = "João NÃO está acompanhado";
         //   }

            //if (idadeJoao >= 18 && acompanhado == true)
            if (idadeJoao <=18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
