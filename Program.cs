namespace Console_Calculator
{
    // Handles bulk of calculations.
    using System;

    namespace Console_Calculator
    {
        // Handles bulk of calculation work.
        class Calculator
        {
            // Public function that will be called to do calculations.
            // Accepts three parameters: two doubles and one string. Returns a double.
            public static double DoOperation(double num1, double num2, string operation)
            {
                // Default value is "not-a-number" used if an operation such as divison could result in an error.
                double result = double.NaN;

                // Switch used to handle actual calculations.
                // Utilizes the string parameter passed into DoOperation.
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
                    // Default text for incorrect option entries.
                    default:
                        Console.WriteLine("Please enter an appropriate operand.");
                        break;
                }

                return result;
            }
        }

        // Main program; handles UI and error-handling.
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("C# Console Calculator");
                Console.WriteLine("Written in C# by TK Tran");
                Console.WriteLine("---------------------");

                // Continue loop until endApp is true.
                bool endApp = false;

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
                    // TryParse returns booleans. If a string representation of a number can be converted, TryParse returns true.
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
                    Console.Write("Your option? ");

                    // Assign user input into variable.
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
                            // String composite formatting.
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
                        // Flips endApp to true and ends while loop
                        endApp = true;
                    }
                    Console.WriteLine("\n");
                }

                return;
            }
        }
    }
}
