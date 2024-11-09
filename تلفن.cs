using System;

namespace PhoneNumberFilter
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Enter a string containing phone numbers:");
            string input = Console.ReadLine();
            int length = input.Length;

            Console.WriteLine("Valid phone numbers are:");

            for (int i = 0; i <= length - 10; i++)
            {
                
                string potentialNumber = input.Substring(i, 10);

                 
                if (potentialNumber[0] == '0' && potentialNumber.Length == 10 && HasTwoDifferentDigits(potentialNumber))
                {
                    Console.WriteLine(potentialNumber);
                }
            }

            return 0;
        }

         
        static int HasTwoDifferentDigits(string number)
        {
            char first = number[0];
            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] != first)
                {
                    return 1; 
                }
            }
            return 0; 
        }
    }
}
