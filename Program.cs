using System;

namespace Console_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
            // Declares vars to be used in math.
            double num1;
            double num2;

            // Title.
            Console.WriteLine("C# Console Calculator");
            Console.WriteLine("---------------------\n");

            // Prompts user for first number.
            Console.WriteLine("Type a number, then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Prompts user for second number.
            Console.WriteLine("Type another number, then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Prompts user for operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\t+ to Add");
            Console.WriteLine("\t- to Subtract");
            Console.WriteLine("\t* to Multiply");
            Console.WriteLine("\t/ to Divide");

            // Switch statement to do the math based on user input.
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            // Wait for user response before closing.
            Console.WriteLine("Press any key to close the Calculator");
            Console.ReadKey();
        }
	}
}