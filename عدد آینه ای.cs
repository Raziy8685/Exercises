using System;

class MirrorNumbers
{
    int start;
    int end;

   
    public MirrorNumbers()
    {
        Console.Write("Enter the first number: ");
        start = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        end = int.Parse(Console.ReadLine());
    }

    
    public void DisplayMirrorNumbers()
    {
        Console.WriteLine("Mirror numbers between {0} and {1}:", start, end);
        for (int i = start; i <= end; i++)
        {
            if (IsMirrorNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    
    bool IsMirrorNumber(int number)
    {
        int original = number;
        int reversed = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        return original == reversed;
    }
}

class Program
{
    
    void Run()
    {
        MirrorNumbers mirrorNumbers = new MirrorNumbers();
        mirrorNumbers.DisplayMirrorNumbers();
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}
