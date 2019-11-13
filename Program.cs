// Test test test

using System;

namespace Console_Calculator
{
    // Handles bulk of calculation work.
    class Calculator
    {
        // Public function that will be called to do calculations; returns a double.
        public static double DoOperation(double num1, double num2, string operation)
        {
            // Default value is "not-a-number" used if an operation such as divison could result in an error.
            double result = double.NaN;

            // Switch used to do the math.
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 + num2;
                    break;
                case "/":
                    // Prompts user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }

    // Handles user interface and error-capturing work.
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title at the top of console
            Console.WriteLine("C# Console Calculator");
            Console.WriteLine("---------------------");

            while (!endApp)
            {
                // Declare vars and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Prompt user for first number.
                Console.WriteLine("Enter the first number: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                // TryParse returns bool. If a string representation of a number can be converted, TryParse returns true.
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("Invalid input. Please enter an integer: ");
                    numInput1 = Console.ReadLine();
                }

                // Prompt user for second number.
                Console.WriteLine("Enter the second number: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("Invalid input. Please enter an integer: ");
                    numInput2 = Console.ReadLine();
                }

                // Prompt user for an operator.
                Console.WriteLine("Choose an operator from the following: ");
                Console.WriteLine("\t+ to add");
                Console.WriteLine("\t- to subtract");
                Console.WriteLine("\t * to multiply");
                Console.WriteLine("\t/ to divide");
                Console.Write("Your option: ");

                string operation = Console.ReadLine();

                // Exception handling.
                try
                {
                    // Referencing Calculator class.
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, operation);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error! \n");
                    }
                    else
                    {
                        Console.WriteLine("Your result: {0:0.##} \n", result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception occurred while attempting the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("---------------------");

                // Wait for user to respond before closing.
                Console.WriteLine("Press 'z' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "z")
                {
                    endApp = true;
                }

                // Friendly linespacing :)
                Console.WriteLine("\n");
            }
            return;
        }
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Declares vars to be used in math.
//        double num1;
//        double num2;

//        // Title.
//        Console.WriteLine("C# Console Calculator");
//        Console.WriteLine("---------------------\n");

//        // Prompts user for first number.
//        Console.WriteLine("Type a number, then press Enter");
//        num1 = Convert.ToDouble(Console.ReadLine());

//        // Prompts user for second number.
//        Console.WriteLine("Type another number, then press Enter");
//        num2 = Convert.ToDouble(Console.ReadLine());

//        // Prompts user for operator.
//        Console.WriteLine("Choose an operator from the following list:");
//        Console.WriteLine("\t+ to Add");
//        Console.WriteLine("\t- to Subtract");
//        Console.WriteLine("\t* to Multiply");
//        Console.WriteLine("\t/ to Divide");

//        // Switch statement to do the math based on user input.
//        switch (Console.ReadLine())
//        {
//            case "+":
//                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
//                break;
//            case "-":
//                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
//                break;
//            case "*":
//                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
//                break;
//            case "/":
//                // Prompts user to enter non-zero divisor until they do so.
//                while (num2 == 0)
//                {
//                    Console.WriteLine("Enter a non-zero divisor: ");
//                    num2 = Convert.ToInt32(Console.ReadLine());
//                }
//                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
//                break;
//        }

//        // Wait for user response before closing.
//        Console.WriteLine("Press any key to close the Calculator");
//        Console.ReadKey();
//    }
//}