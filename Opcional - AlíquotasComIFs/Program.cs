using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional___AlíquotasComIFs
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
                Console.WriteLine("O seu salário é R$" + salario + ". A alíquita será de 7,5%, podendo deduzir até R$142");
            if (salario >= 2800.01 && salario <= 3751.0)
                Console.WriteLine("O seu salário é R$" + salario + ". A alíquota será de 15%, podendo deduzir até R$350");
            if (salario >= 3751.01 && salario <= 4664.0)
                Console.WriteLine("O seu salário é R$" + salario + ". A alíquota será de 22,5%, podendo deduzir até R$636");
            Console.ReadLine();
            
        }
    }
}
