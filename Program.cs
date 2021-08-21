using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Console Calculator designed to ask a user for two numbers.
                And thne ask the user if they want to add, subtract, multiply, or divide
                then display the output. 
            */

            int userInput1 = 0;
            int userInput2 = 0;

            Console.WriteLine("This Calculator Program!");
            
            Console.WriteLine("Please enter the first number: ");
            userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            userInput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The numbers entered are {userInput1} and {userInput2}");
        }
    }
}
