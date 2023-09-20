namespace Ededin_quvveti
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int n, i;
                n = Convert.ToInt32(Console.ReadLine());

                    while (n > 1)
                    {
                        i = n % 3;
                        if (i != 0) break; //proses durur
                        n = n/3;
                    }
                    if (n == 1)
                        Console.WriteLine("3-ün qüvvətidir");
                    else
                        Console.WriteLine("3-ün qüvvəti deyil");


        }
    }
}