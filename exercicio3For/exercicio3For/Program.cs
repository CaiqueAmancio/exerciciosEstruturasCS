using System;
using System.Globalization;

namespace exercicio3For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de notas que irá calcular " +
                "a média poderada: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line [0], CultureInfo.InvariantCulture);
                double b = double.Parse(line [1], CultureInfo.InvariantCulture);
                double c = double.Parse(line [2], CultureInfo.InvariantCulture);

                double mediaPonderada = ((a * 2) + (b * 3) + (c * 5)) / (10);

                Console.WriteLine($"A média ponderada é {mediaPonderada.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine("Fim");
        }
    }
}
