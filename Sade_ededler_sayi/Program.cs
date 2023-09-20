namespace Sade_ededler_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10, counter = 0;
            bool sade_ededir = true;

            for (int i = 3; i < n; i++)
            {
                for (int j = 2; j < n; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        sade_ededir = false;
                        break;
                    }
                    if (sade_ededir)
                    {
                        counter++;
                        break;
                    }
                    sade_ededir = true;
                }
            }
            Console.WriteLine("cemi: " + counter);
        }
    }
}