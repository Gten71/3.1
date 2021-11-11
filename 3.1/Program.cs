using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число n:");
                int n = int.Parse(Console.ReadLine());
                double S = 0;
                for (int k = 1; k <= n; k++)
                {
                    if (k == 3 || k == 4) continue;
                    long Fact = 1;
                    for (int i = 1; i <= k; i++) Fact *= i;
                    S += Math.Pow(k - 3, k - 5) * (k + 7) / Fact;
                }
                Console.WriteLine($"A={S:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}