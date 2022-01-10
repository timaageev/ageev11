using System;

namespace зачет
{
    class Program
    {
        // Если (mod 6) имеется в виду (mod n)
        static bool IsIdempotent(int i, int n)
        {
            long i2 = i * i;
            if (i2 % n == i % n)
                return true;
            return false;
        }
        static int M(int n)
        {
            int max = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (IsIdempotent(i, n))
                {
                    max = i;
                    return max;
                }
            }
            return max;
        }

        // Если (mod 6) так и остаётся фиксированным для любого n
        /*
        static bool IsIdempotent(int n)
        {
            long n2 = n*n;
            if (n2 % 6 == n % 6)
                return true;
            return false;
        }
        static int M(int n)
        {
            int max = 1;
            for(int i = n-1; i >= 0; i--)
            {
                if (IsIdempotent(i))
                {
                    max = i;
                    return max;
                }
            }
            return max;
        }
        */

        static void Main()
        {

            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"M({n}) = {M(n)}");

        }
    }
}
