using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            //o tipo char guarda apenas um caractere da tabela ascii. Por isso, quando passamos um valor numérico, teremos como saída o caractere correspondente ao número na tabela ascii

            char primeiraLetra = 'a'; // char armazena somente um caractere / "" entende como texto, e não um caractere
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65; //aqui ocorre a conversão de inteiro para char, se não o C# não aceita
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1); // se eu tirar o parentese da expressão, o compilador entende que só quero fazer um cast de primeiraLEtra
            Console.WriteLine(primeiraLetra);
           

            string titulo = "Alura Cursos de tecnologia " + 2021; //o  numero será convertido em texto e será concatenado na string
            Console.WriteLine(titulo);

            //string não pode quebrar linha, a não ser que usemos o @
            //string cursosProgramacao = " - .NET" +
            //  " - Java" +
            //" - Javascript";
            //Console.WriteLine(cursosProgramacao)

            string cursosProgramacao = 
@"- .NET
- Java
- Javascript";
            Console.WriteLine(cursosProgramacao);




            Console.WriteLine("Programa finalizado, tecle enter para sair");
            Console.ReadLine();
        }

    }
}
