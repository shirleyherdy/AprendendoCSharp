using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("testando condicionais");

        int idade = 10;
        int quantidadePessoas = 1;
        bool acompanhado = false;

        if (quantidadePessoas >= 2)
        {
            acompanhado = true;
        }
        else
        {
            acompanhado = false;
        }

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine("Seja bem vindo");
        }
        else
        {
            Console.WriteLine("infelizmente voce nao pode entrar");
        }
        Console.ReadLine();

    }
}