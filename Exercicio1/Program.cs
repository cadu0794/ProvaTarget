using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 12, soma = 0, k = 1;

            while (k < i)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine("###############");
            Console.WriteLine("O total da soma é: " + soma);
            Console.WriteLine("###############");
            Console.ReadLine();
        }
    }
}
