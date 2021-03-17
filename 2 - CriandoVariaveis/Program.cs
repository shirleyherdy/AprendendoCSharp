using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variáveis");

            int idade;//toda variável deve ser declarada antes do uso, para declarar temos que definir o seu tipo
            idade = 32;
            Console.WriteLine(idade);//para imprimir o valor da variável, temos que digitar dentro do () sem ".

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;//precedência de operadores - primeiro multiplicação e divisão e depois soma e subtração.
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;//dessa forma faço a soma primeiro
            Console.WriteLine(idade);
            Console.WriteLine("Sua idade é " + idade + "!!!");//assim conseguimos concatenar uma frase com o valor da variável.

            Console.WriteLine("Projeto finalizado, tecle enter para sair");
            Console.ReadLine();
        }
    }
}
