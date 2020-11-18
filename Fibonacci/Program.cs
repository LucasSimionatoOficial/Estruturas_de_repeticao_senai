using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string fibonacci = "0; 1; 1";
            int f1 = 1;
            int f2 = 1;
            int fibo = 0;
            while (fibo < 500) {
                fibo = f1 + f2;
                f1 = f2;
                f2 = fibo;
                fibonacci += "; " + fibo;
            }
            Console.WriteLine("Fibonacci até um número depois de 500");
            Console.WriteLine(fibonacci + ".");
        }
    }
}
