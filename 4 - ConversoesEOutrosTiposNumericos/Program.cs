using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Conversões e outros tipos numéricos");

            double salario;
            salario = 2645.60;

            int salarioEmInteiro;
            //salarioEmInteiro = salario;
            salarioEmInteiro = (int)salario; // casting - não posso igualar um double a int já que vou perder casas decimais, a não ser que eu indique com o (int) antes da variável que quero manter como int.

            Console.WriteLine("Salário inteiro é igual a R$" + salarioEmInteiro);

            //int idade;
            //idade = 13000000000; variáveis do tipo int só armazenam 32 bits, para armezar numeros muito grandes podemos usar "long", mas o long não é muito usado porque usa mais memória
            long idade;
            idade = 13000000000;
            Console.WriteLine("A idade do universo é " + idade + " anos");

            // da mesma forma que o long precisa reservar mais memória para armezar o valor (64 bits), pode acontecer de não precisarmos usar o int para armazenar um valor muito pequeno, pra isso usamos o short
            short quantidadeProdutos;
            quantidadeProdutos = 150;//o short ocupa 16 bits, ocupa por volta de 16 mil.
            Console.WriteLine("A quantidade de produtos é " + quantidadeProdutos);

            float altura = 1.80f; //float tem precisão curta após a vírgula, então precisamos acrecentar o f para mostrar para o código que queremos casas decimais para o float
            //posso resumir o código declarando a variável e atribuindo valor como acima - é a melhor prática
            Console.WriteLine("A altura é " + altura);

           
            Console.WriteLine("Projeto finalize, aperte enter para fechar.");
            Console.ReadLine();
        }
    }
}
