using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 30;
            long a = 1, b = 1;


            Console.WriteLine(a);
            Console.WriteLine(b);


            for (int i = 2; i < n; i++)
            {
                long next = a + b;
                Console.WriteLine(next);
                a = b;
                b = next;
            }
        }
    }
}
