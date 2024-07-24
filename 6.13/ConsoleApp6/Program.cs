using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a;
            int b;

            do
            {
                Console.Write("Digite um valor positivo para X: ");
                x = int.Parse(Console.ReadLine());
            } while (x <= 0);


            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());


            do
            {
                Console.Write("Digite o valor de B (deve ser maior que A): ");
                b = int.Parse(Console.ReadLine());
            } while (b <= a);

            Console.WriteLine($"Tabuada de {x} no intervalo de {b} para {a}:");
            for (int i = b; i >= a; i--)
            {
                Console.WriteLine($"{x} x {i} = {x * i}");
            }
        }
    }
}
