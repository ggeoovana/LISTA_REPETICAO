using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Valor1;
            int Valor2;

            Console.WriteLine("Digite o primeiro valor:");
            Valor1 = int.Parse(Console.ReadLine());

            do
            {

                Console.WriteLine("Digite o segundo valor:");
                Valor2 = int.Parse(Console.ReadLine());

                if (Valor2 <= Valor1)
                {
                    Console.WriteLine("O segundo valor deve ser maior que o primeiro. Tente novamente.");
                }

            } while (Valor2 <= Valor1);

            // Aqui, segundoValor é garantidamente maior que primeiroValor
            Console.WriteLine($"Você digitou corretamente os valores: {Valor1} e {Valor2}");
        }
    }
}
