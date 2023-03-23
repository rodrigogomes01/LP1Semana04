using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lucas(0);
            Lucas(2);
            Lucas(7);
        }

        private static int Lucas(int n)
        {
            int total;
            if (n == 0)
                total = 2;

            else if (n == 1)
                total = 1;

            else
                total = Lucas(n - 1) + Lucas(n - 2);

            Console.WriteLine(total);
            return total;
        }
    }
}