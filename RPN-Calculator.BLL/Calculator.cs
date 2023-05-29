using Utils.Shared;

namespace RPN_Calculator.BLL
{
    public class Calculator
    {
        public static Stack<decimal> stackList = new Stack<decimal>();
        private static decimal result;
        public static void OperationsMenu()
        {
        MainMenu: Menu.CalculatorMainMenu();
        Start: Console.Write("Pick an Option: ");
            string option = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(option) && !int.TryParse(option, out int opt))
            {
                Utils.Shared.Utils.ErrorPrompts("Invalid inputs. Try again!");
                goto Start;
            }

            switch (option)
            {
                case "1":
                    Console.Write("Write expression: ");
                    string exp = Console.ReadLine();
                    result = PerformOperation(exp);
                    Console.WriteLine($"Result: {result}");
                    break;
                case "2":
                    StartSqrtOperation: Console.WriteLine("Square root operation");
                    Console.Write("==> Input: ");
                    string number = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(number) || !double.TryParse(number, out double num))
                    {
                        Utils.Shared.Utils.ErrorPrompts("Invalid inputs... Try again!");
                        goto StartSqrtOperation;
                    }
                        PerformSquareRootOperation(number);
                    break;
                case "0":
                    Console.Clear();
                    Console.WriteLine("Exiting the application");
                    return;
                default:
                    Utils.Shared.Utils.ErrorPrompts("Invalid inputs");
                    goto Start;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDo you want to perform another operation?\n***Press Y or y: to perform " +
                "another operation.\n***Press any other key: to exit application");
            Console.ResetColor();
            Console.Write("====> ");
            string options = Console.ReadLine();

            if (options == "Y" || options == "y")
            {
                Console.Clear();
                goto MainMenu;
            }
            else
            {
                Console.WriteLine("Exiting application");
                return;
            }

        }

        public static decimal PerformOperation(string exp)
        {
            try
            {
                string[] tokens = exp.Split(' ');

                foreach (string token in tokens)
                {
                    if (decimal.TryParse(token, out decimal operands))
                    {
                        decimal number = decimal.Parse(token);

                        stackList.Push(operands);
                    }
                    else
                    {
                        PerformOperations(token);
                    }
                }


                return stackList.Pop();
            }
            catch
            {
                Utils.Shared.Utils.ErrorPrompts("Invalid expression. Try operation again");
                return 0;
            }
        }

        public static void PerformOperations(string token)
        {

            switch (token)
            {
                case "+":
                    PerformBinaryOperation((a, b) => a + b);
                    break;
                case "-":
                    PerformBinaryOperation((a, b) => a - b);
                    break;
                case "*":
                    PerformBinaryOperation((a, b) => a * b);
                    break;
                case "/":
                    PerformBinaryOperation((a, b) => a / b);
                    break;
                default:
                    Console.WriteLine("Invalid or incomplete operation. Kindly" +
                        " input a valid expression");
                    return;
            }

        }

        private static decimal PerformBinaryOperation(Func<decimal, decimal, decimal> operation)
        {
            Calculator calculate = new Calculator();
            if (stackList.Count < 2)
            {
                throw new InvalidOperationException("Insufficient operands for the operation.");
            }

            decimal b = stackList.Pop();
            decimal a = stackList.Pop();
            decimal result = operation(a, b);
            stackList.Push(result);
            return result;
        }

        private static double PerformSquareRootOperation(string number)
        {
            if (!string.IsNullOrWhiteSpace(number) && double.TryParse(number, out double num))
            {
                double result = Math.Sqrt(num);
                Console.WriteLine($"Square root of {number} is {result}");
            }   
            
           
            return (double)result;
        }
    }
}