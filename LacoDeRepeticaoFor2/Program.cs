﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Programa
    {
        static void Main(String[] args)
        {
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


