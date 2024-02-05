using Calculator;

namespace Console_Calculator;

class Program
{
    public class ConsoleOperataions
    {
        SaveResult printResults = new SaveResult();
        public void GetOperations()
        {
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
        }

        public double[] DoValidations()
        {
            // Declare variables and set to empty.
            double[] inputArr = new double[2];
            string numInput1 = "";
            string numInput2 = "";

            // Ask the user to type the first number.
            Console.Write("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            //if numInput is not a number 
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput1 = Console.ReadLine();
            }
            inputArr[0] = cleanNum1;

            // Ask the user to type the second number.
            Console.Write("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput2 = Console.ReadLine();
            }
            inputArr[1] = cleanNum2;
            return inputArr;
        }

        public void BasicCalculator()
        {

            double num1 = 0;
            double num2 = 0;
            Console.Write("Type a number, and then press Enter: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Type a number, and then press Enter: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            GetOperations();
            Console.WriteLine("Select and press Enter");
            string op = Console.ReadLine();
            BasicCalculator basicCalculator = new BasicCalculator();
            basicCalculator.BasicOperations(num1, num2, op);
        }

        public void RevisedCalculator()
        {
            RevisedCalculator revisedCalculator = new RevisedCalculator();
            bool endApp = false;
            while (!endApp)
            {

                double[] inputArr = DoValidations();
                GetOperations();
                string op = Console.ReadLine();
                try
                {
                    double result = 0;

                    result = revisedCalculator.DoOperation(inputArr[0], inputArr[1], op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                    printResults.results(inputArr[0], inputArr[1], result, "RevisedCalculator");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;

        }


        public void ImprovedCalculator()
        {
            ImprovedCalculator improvedCalculator = new ImprovedCalculator();
            bool endApp = false;

            while (!endApp)
            {
                Console.WriteLine("Enter the Expression");
                string expression = Console.ReadLine();

                try
                {
                    double result = 0;

                    result = improvedCalculator.Evaluate(expression);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                    if (double.IsNaN(result))
                    {
                        printResults.results(expression, "Undefined ", "Improved Calculator");
                    }
                    else
                    {
                        printResults.results(expression, result.ToString("F2"), "Improved Calculator");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the Improved Calculator app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }

                Console.WriteLine("\n"); // Friendly linespacing.

            }
            return;


        }

        public void SelectCalculator()
        {
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            int choice = 4;

            do
            {



                Console.WriteLine("\nSelect the calculator \n" +
                    "1) Basic Calculator \n" +
                    "2) Revised Calculator \n" +
                    "3) Improved Calculator\n" +
                    "4) Exit");

                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    BasicCalculator();
                }
                else if (choice == 2)
                {
                    RevisedCalculator();
                }
                else if (choice == 3)
                {
                    ImprovedCalculator();

                }
                else if (choice == 4)
                {
                    Console.WriteLine("Exiting the application");
                }
                else
                {
                    Console.WriteLine("Enter valid choice");
                }


            } while (choice != 4);
        }

    }


    static void Main(string[] args)
    {
        Console.WriteLine();
        ConsoleOperataions consoleOperataions = new ConsoleOperataions();
        consoleOperataions.SelectCalculator();


    }
}



    


