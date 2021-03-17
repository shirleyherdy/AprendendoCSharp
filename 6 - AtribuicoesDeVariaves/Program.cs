using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___AtribuicoesDeVariaves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuções de Variáveis");

            int idade = 22;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);
            //Quando nós atribuímos o valor de uma variável para outra variável, a última não será alterada como a primeira. A linguagem C# fará com que o valor da primeira variável armazenada seja verificado e vai copiá-lo para a segunda. Desta forma, entendemos que não existe uma conexão entre as duas variáveis.
            //O que de fato acontece é que um valor é copiado para a outra variável, sendo este duplicado na memória do computador.Talvez, você possa ter entendido isso de forma intuitiva. Mas agora temos uma base para quando começarmos a falar de orientação a objeto, e conseguirmos entender estas e outras variáveis de referência com mais detalhes.
            
            Console.WriteLine("Programa finalizado. Tecle enter para sair.");
            Console.ReadLine();
        }
    }
}
