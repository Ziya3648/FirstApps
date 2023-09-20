using System;

namespace Ededin_mertebesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0;
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) n = n * -1;
            while (n > 0)
            {
                n /= 10;
                ++i;
            }
                Console.WriteLine(i);

        }
    }
}