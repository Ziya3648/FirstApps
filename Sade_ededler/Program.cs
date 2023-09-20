namespace Sade_ededler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            bool sade_ededir = true;

            for (int i = 2; i < n; i++)
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
                        Console.WriteLine(i);
                        break;
                    }
                    sade_ededir = true;
                }
            }
        }
    }
}