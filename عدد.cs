using System.Numerics;
char key;
BigInteger number = 0;

do
{
    do
    {
        key = Console.ReadKey(true).KeyChar;
    } while (!char.IsDigit(key) && key !='A');
    if (key != 'A')
    {
        Console.Write(key);
        number = number * 10 +
            Convert.ToInt32(key.ToString());
    }
} while (key != 'A');
Console.WriteLine();
Console.WriteLine(number);