using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            double n1 = 0;
            double n2 = 0;
            double res = 0;

            // Entrada de dados
            Console.WriteLine("Hello World!");

            Console.WriteLine("Digite por gentileza o primeiro número:");
            Console.Beep();
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite por gentileza o segundo número:");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Beep();

            // Processamento dos dados
            res = n1 + n2;

            // Saída dos dados
            Console.WriteLine("A soma é igual a: " + res);
            Console.ReadKey();
        }
    }
}