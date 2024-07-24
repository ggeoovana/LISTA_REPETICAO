using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar;

            do
            {
                int numero;
                do
                {
                    Console.Write("Digite um número inteiro não negativo para calcular o fatorial: ");
                } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0);

                int fatorial = 1;
                for (int i = 2; i <= numero; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"O fatorial de {numero} é {fatorial}");

                do
                {
                    Console.Write("Deseja calcular o fatorial de outro número? (S/N): ");
                    continuar = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                } while (continuar != 'S' && continuar != 'N');

            } while (continuar == 'S');
        }
    }
}
