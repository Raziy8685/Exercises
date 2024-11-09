using System;

namespace SimpleDecisionTree
{
    class Program
    {
        char AskQuestion(string question)
        {
            char answer;
            do
            {
                Console.WriteLine(question + " (y/n): ");
                answer = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (answer != 'y' && answer != 'n'); 
            return answer;
        }

        void Run()
        {
            Console.WriteLine("Welcome to the Food Decision Tree!");

            
            char isHot = AskQuestion("Is the food hot?");

            
            char hasMeat = AskQuestion("Does the food contain meat?");

            
            char isSweet = AskQuestion("Is the food sweet?");

            
            if (isHot == 'y' && hasMeat == 'y' && isSweet == 'n')
            {
                Console.WriteLine("The food might be a hot meat dish like steak.");
            }
            else if (isHot == 'y' && hasMeat == 'n' && isSweet == 'y')
            {
                Console.WriteLine("The food might be a hot dessert like apple pie.");
            }
            else if (isHot == 'n' && hasMeat == 'y' && isSweet == 'n')
            {
                Console.WriteLine("The food might be a cold meat dish like a ham sandwich.");
            }
            else if (isHot == 'n' && hasMeat == 'n' && isSweet == 'y')
            {
                Console.WriteLine("The food might be a cold dessert like ice cream.");
            }
            else
            {
                Console.WriteLine("The food might be something simple like a salad.");
            }
        }

        static void Main()
        {
            Program program = new Program();
            program.Run();
        }
    }
}
