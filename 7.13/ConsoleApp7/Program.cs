using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Tabuada do {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }

                Console.WriteLine("Pressione qualquer tecla para continuar para a próxima tabuada...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("FIM DAS TABUADAS.");
        }
    }
}
