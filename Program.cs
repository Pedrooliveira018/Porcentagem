using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porcentagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.WriteLine("Qual é o valor do produto?");
                decimal produto = decimal.Parse(Console.ReadLine());

                     Console.WriteLine("Qual a porcetagem de desconto?");
                decimal desconto = decimal.Parse(Console.ReadLine());

            // Regras

                    if (desconto >= 50 || desconto < 0)
                     Console.WriteLine("A taxa de desconto é invalida!");

                else if (produto < 200)
                    if (desconto > 20)
                     Console.WriteLine("A taxa de desconto é inválida!");

                else if (produto < 100)
                    if (desconto > 10)
                     Console.WriteLine("A taxa de desconto é inválida!");

            // Calculo 

            decimal resultado = produto - (produto * (desconto / 100));
                     Console.WriteLine("O valor final do produto é " + resultado);


        }
    }
}
