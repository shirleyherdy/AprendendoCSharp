using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___CriandoVariaveisDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variáveis ponto flutuante");

            double salario; // tipo double serve para o número ter casas decimais.
            salario = 2645.60; //casas decimais sempre separadas por .!!!
            Console.WriteLine("O valor do seu salário é " + salario);

            double idade;
            idade = 15;//double admite numero inteiro, mas int não aceita double
            Console.WriteLine("A sua idade é " + idade);

            idade = 15 / 2;
            Console.WriteLine("A sua idade é " + idade); //reparar que o resultado será 7 porque eu não demonstrei os números 15 e 2 como double, e sim como int

            idade = 15.0 / 2; // double / int = double ou int / double = double
            Console.WriteLine("A sua idade é " + idade); //reparar que o resultado será 7 porque eu não demonstrei os números 15 e 2 como double, e sim como int

           
            Console.WriteLine("A executação terminou, tecle enter para sair");
            Console.ReadLine();
        }
    }
}
