using System.Numerics;
namespace N6__YP__Task_3_05._04._2025
{
    internal class Program
    {
        static void Main()
        {
            BigInteger[,] B = new BigInteger[4, 5];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 5; j++) B[i, j] = BigInteger.Parse(Console.ReadLine());
            BigInteger pr = 1;
            bool hM = false;
            foreach (var num in B)
                if (num % 3 == 0)
                {
                    pr *= num;
                    hM = true;
                }
            Console.WriteLine(hM ? $"произведение 3 {pr}" : "нет кратных 3");
            BigInteger  sum = 0;
            for (int j = 0; j < 5; j++) sum += B[1, j];
            Console.WriteLine($"Среднне 2 строки  {sum/5}");
            Thread.Sleep(10000);
        }
    }
}
