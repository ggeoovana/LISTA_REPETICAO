using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char resposta;

            do
            {
                Console.WriteLine("Digite a quantidade de números (positivo, menor que vinte): ");
                int N;
                while (!int.TryParse(Console.ReadLine(), out N) || N <= 0 || N >= 20)
                {
                    Console.WriteLine("Quantidade inválida. Digite novamente (positivo, menor que vinte): ");
                }

                int[] numeros = new int[N];
                int maior = int.MinValue;
                int menor = int.MaxValue;
                int soma = 0;
                int positivos = 0;
                int negativos = 0;


                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Digite o {i + 1}º número: ");
                    numeros[i] = int.Parse(Console.ReadLine());

                    if (numeros[i] > maior)
                        maior = numeros[i];
                    if (numeros[i] < menor)
                        menor = numeros[i];

                    soma += numeros[i];

                    if (numeros[i] > 0)
                        positivos++;
                    else if (numeros[i] < 0)
                        negativos++;
                }

                double media = (double)soma / N;

                double porcentagemPositivos = (double)positivos / N * 100;
                double porcentagemNegativos = (double)negativos / N * 100;


                Console.WriteLine($"Maior valor: {maior}");
                Console.WriteLine($"Menor valor: {menor}");
                Console.WriteLine($"Soma dos valores: {soma}");
                Console.WriteLine($"Média aritmética: {media:F2}");
                Console.WriteLine($"Porcentagem de valores positivos: {porcentagemPositivos:F2}%");
                Console.WriteLine($"Porcentagem de valores negativos: {porcentagemNegativos:F2}%");

                Console.WriteLine("Deseja executar novamente? (S/N)");
                resposta = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

            }
            while (resposta == 'S');
        }
    }
}
