using System;
class program
{
    static void Main()
    {
        Console.WriteLine("enter the starting number (m) ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter the starting number (n)");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        for (int i = m; i <= n; i++)
        {
            if ( IsPrime (i))

            {
                Console.WriteLine(i);
            }

        }
    }
    static bool IsPrime (int number)
    {
        if (number <= 1)
        { return false; }

        for (int j = 2; j <= Math.Sqrt(number); j++)
        {
            if (number % j == 0)
            {
                return false;
            }
        }
        return true;
    }
}
