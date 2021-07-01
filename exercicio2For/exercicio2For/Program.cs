using System;

namespace exercicio2For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de números que irá testar: ");
            int n = int.Parse(Console.ReadLine());

            int count_in = 0;
            int count_out = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20)
                {
                    count_in += 1;
                }
                else
                {
                    count_out += 1;
                }
            }
            Console.WriteLine(count_in + " in");
            Console.WriteLine(count_out + " out");
        }
    }
}
