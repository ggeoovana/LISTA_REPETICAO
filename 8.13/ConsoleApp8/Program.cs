using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma dos números inteiros positivos de 1 a 100 é: {soma}");
        }

    }
}
