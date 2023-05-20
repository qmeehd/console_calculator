using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            // NAMING CALCULATOR/ ASSIGNINNG CMD PROMPT NAME
            Console.WriteLine("---Console Calculator---");
            Console.Title = "Console Calculator";

            // USER INPUTTED NUMBER IS STORED INTO NUM1 VAR
            Console.WriteLine("\nPlease enter the first number: ");
            string input1 = Console.ReadLine();
            int num1;

            // CHECKING IF 
            bool isValid1 = int.TryParse(input1, out num1);
            if (!isValid1)
            {
                Console.WriteLine("Invalid input for the first number. Please try again.");
                return;
            }


            Console.WriteLine("Enter the second number: ");
            string input2 = Console.ReadLine();
            int num2;

            bool isValid2 = int.TryParse(input2, out num2);
            if (!isValid2)
            {
                Console.WriteLine("Invalid input for the second number. Please try again.");
                return;
            }
            //USER SELECTS ORDER OF OPERATIONS
            Console.WriteLine("Select your choice: a/s/m/d (Addition, Subtraction, Multiplication, Divison)");
            string response = Console.ReadLine();
            //SET RESULT VAR TO 0
            int result = 0;
            //EVALUATE EACH CASE IF CONDITION IS MET AND SET RESULT(VAR) TO THE RESULT.
            switch (response)
            {
                // ADDITION OPERATION
                case "a":
                     result = num1 + num2;
                    break;
                // SUBTRACTION OPERATION
                case "s":
                     result = num1 - num2;
                    break;
                // MULTIPLICATION OPERATION
                case "m":
                     result = num1 * num2;
                    break;
                // DIVISON OPERATION
                case "d":
                     result = num1 / num2;
                    break;
                // IN THE CASE OF INVALID OPERATION
                default:
                    Console.WriteLine("Please enter a valid operation!");
                    return;

            }
            // PRINTS RESULT
            Console.WriteLine($"\nThe answer is {result}.");
        }
    }
}
