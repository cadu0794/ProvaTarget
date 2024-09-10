using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] faturamentoDiario = { 1330, 50, 1700, 0, 550, 750, 1400, 0, 3100, 1250 };

        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;

        double somaFaturamento = 0;
        int diasComFaturamento = 0;

        foreach (double faturamento in faturamentoDiario)
        {
            if (faturamento > 0)
            {
                if (faturamento < menorFaturamento)
                {
                    menorFaturamento = faturamento;
                }

                if (faturamento > maiorFaturamento)
                {
                    maiorFaturamento = faturamento;
                }

                somaFaturamento += faturamento;
                diasComFaturamento++;
            }
        }

        double mediaAnual = somaFaturamento / diasComFaturamento;

        int diasAcimaDaMedia = faturamentoDiario.Count(faturamento => faturamento > mediaAnual);

        Console.WriteLine("Menor faturamento: " + menorFaturamento);
        Console.WriteLine("Maior faturamento: " + maiorFaturamento);
        Console.WriteLine("Dias com faturamento acima da média anual: " + diasAcimaDaMedia);

        Console.ReadLine();
    }
}
