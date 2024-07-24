using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo = string.Empty;

            while (sexo != "F" && sexo != "M")
            {
                Console.Write("Por favor, insira o sexo (F ou M): ");
                sexo = Console.ReadLine().ToUpper();

                if (sexo != "F" && sexo != "M")
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }

            Console.WriteLine("Sexo inserido: " + sexo);
        }
    }
}
