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
            int userSelection = 0;
            int total = 0;
            bool checkInput1 = false;
            bool checkInput2 = false;
            bool checkSelection = false;

            Console.WriteLine("This Calculator Program!");
            
            //loop to check for correct input (first input)
            while (!checkInput1)
            {
                Console.WriteLine("Please enter the first number: ");
                var userInput1Check = Console.ReadLine();

                //check input
                checkInput1 = int.TryParse(userInput1Check, out userInput1);

                if (!checkInput1)
                {
                    Console.WriteLine("Please enter a numerical value!");
                }
            }

            //loop to check for correct input (second input)
            while (!checkInput2)
            {
                Console.WriteLine("Please enter the second number: ");
                var userInput2Check = Console.ReadLine();

                //check input
                checkInput2 = int.TryParse(userInput2Check, out userInput2);

                if (!checkInput2)
                {
                    Console.WriteLine("Please enter a numerical value!");
                }
            }

            while (!checkSelection)
            {
                Console.WriteLine("Please enter if you would like to (#):");
                Console.WriteLine("1. Add\n2. Subtract\n3. Multiply \n4. Divide");

                userSelection = Convert.ToInt32(Console.ReadLine());
                

                if (userSelection == 1 || userSelection == 2 || userSelection == 3 || userSelection == 4)
                {
                    checkSelection = true;
                }

            }
            

            Console.WriteLine($"The numbers entered are {userInput1} and {userInput2} and option #{userSelection}");

            if (userSelection == 1)
            {
                total = userInput1 + userInput2;
                Console.WriteLine($"Adding the two numbers together = {total}");
            }
            else if (userSelection == 2)
            {
                total = userInput1 - userInput2;
                Console.WriteLine($"Subtracting the two numbers together = {total}");
            }
            else if (userSelection == 3)
            {
                total = userInput1 * userInput2;
                Console.WriteLine($"Multiplying the two numbers together = {total}");
            }
            else
            {
                total = userInput1 / userInput2;
                Console.WriteLine($"Dividing the two numbers together = {total}.");
            }
                    
        }
    }
}
