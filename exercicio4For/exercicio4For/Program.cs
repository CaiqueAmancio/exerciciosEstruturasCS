using System;
using System.Globalization;

namespace exercicio4For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de divisão deseja realizar: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                double x = double.Parse(line[0], CultureInfo.InvariantCulture);
                double y = double.Parse(line[1], CultureInfo.InvariantCulture);

                double divisao = x / y;

                if (y == 0)
                {
                    Console.WriteLine("Divisão impossível\n");
                }
                else
                {
                    Console.WriteLine($"Resultado da divisão: {divisao}\n");
                }

            }

        }
    }
}
