using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
int soma = 0;
int maiorValor = int.MinValue;

Console.WriteLine("Digite 10 valores positivos:");

for (int i = 0; i < 10; i++)
{
    int valor = 0;
    bool entradaValida = false;

    while (!entradaValida)
    {
        Console.Write($"Valor {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out valor) && valor > 0)
        {
            entradaValida = true;
            valores[i] = valor;
            soma += valor;
            if (valor > maiorValor)
            {
                maiorValor = valor;
            }
        }
        else
        {
            Console.WriteLine("Erro: Por favor, insira um valor positivo.");
        }
    }
}
        }
    }
}
