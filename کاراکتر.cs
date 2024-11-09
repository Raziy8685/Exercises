using System;

namespace CharacterInputOnly
{
    class Program
    {
         
        char GetCharacter()
        {
            char character;
            bool isSingleCharacter;

            do
            {
                Console.Write("Please enter a single character: ");
                string input = Console.ReadLine();

                
                isSingleCharacter = input.Length == 1;

                if (isSingleCharacter)
                {
                    character = input[0]; 
                    Console.WriteLine("You entered the character: " + character);
                    return character;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only one character.");
                }

            } while (!isSingleCharacter); 

            return '\0'; 
        }

        
        char Run()
        {
            return GetCharacter();
        }

        
        static void Main()
        {
            Program program = new Program();
            char result = program.Run();
        }
    }
}
