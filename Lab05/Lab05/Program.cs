using System;

namespace Lab05
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            System.Diagnostics.Debug.Write("Entering Main() method");
            for (int i = 0; i < 25; i++)
            {
                Console.Write(Fibonacci(i));
                var fib = Fibonacci(i);
                Console.Write(", ");
            }

            Console.ReadKey();
        }
    }
}
