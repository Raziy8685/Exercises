using System;

namespace FibonacciCheck
{
    class Program
    {
        static int IsFibonacci(int n)
        {
            int a = 0, b = 1, temp;

            
            if (n == a || n == b)
                return 1;

             
            while (b < n)
            {
                temp = a + b;
                a = b;
                b = temp;

                if (b == n)
                    return 1;
            }

             
            return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it is in the Fibonacci sequence: ");
            int n = int.Parse(Console.ReadLine());

           
            int result = IsFibonacci(n);
            if (result == 1)
                Console.WriteLine("{n} is in the Fibonacci sequence.");
            else
                Console.WriteLine("{n} is not in the Fibonacci sequence.");
        }
    }
}
