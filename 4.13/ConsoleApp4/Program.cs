using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor;

            while (true)
            {
                Console.Write("Digite um valor positivo: ");
                if (int.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número inteiro positivo.");
                }
            }


            Console.WriteLine($"\nTabuada do {valor}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{valor} x {i} = {valor * i}");
            }
        }
    }
}
