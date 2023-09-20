using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result, n1, n2;
            char symbol;

            Console.WriteLine("Birinci reqemi daxil edin:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ikinci reqemi daxil edin:");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Simvolu (+,-,*,/) daxil edin:");
            symbol = Convert.ToChar(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = n1 + n2;
                    Console.WriteLine("Cemi:" + result);
                    break;
                case '-':
                    result = n1 - n2;
                    Console.WriteLine("Ferq:" + result);
                    break;
                case '*':
                    result = n1 * n2;
                    Console.WriteLine("Hasil:" + result);
                    break;
                    
                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine("Bolunen 0 reqemi ola bilmez");
                        break;
                    }
                    result = n1 / n2;
                    Console.WriteLine("Qismet:" + result);
                    break;
                default:
                    Console.WriteLine("Yalnis simvol '"+symbol+"' daxil etdiniz. '+,-,*,/' simvolundan birini daxil edin");
                    break;

            }
        }
    }
}