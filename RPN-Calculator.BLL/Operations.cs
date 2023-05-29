namespace RPN_Calculator.BLL
{
    public class Operations
    {
       

        

        public static decimal Addition(decimal operandOne, decimal operandTwo)
        {
            decimal result = operandOne + operandTwo;

            Console.WriteLine("\nPerforming addition...");
            Console.WriteLine($"Operand One: {operandOne}");
            Console.WriteLine($"Operand Two: {operandTwo}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Result: {result} \n");
            Console.ResetColor();

            return result;
        }

        public static decimal Multiplication(decimal operandOne, decimal operandTwo)
        {
            decimal result = operandOne * operandTwo;

            Console.WriteLine("\nPerforming multiplication...");
            Console.WriteLine($"Operand One: {operandOne}");
            Console.WriteLine($"Operand Two: {operandTwo}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Result: {result} \n");
            Console.ResetColor();

            return result;
        }

        public static decimal Subtraction(decimal operandOne, decimal operandTwo)
        {
            decimal result = operandOne - operandTwo;

            Console.WriteLine("\nPerforming subtraction...");
            Console.WriteLine($"Operand One: {operandOne}");
            Console.WriteLine($"Operand Two: {operandTwo}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Result: {result} \n");
            Console.ResetColor();

            return result;
        }

        public static decimal Division(decimal operandOne, decimal operandTwo)
        {
            decimal result = operandOne / operandTwo;

            Console.WriteLine("\nPerforming division...");
            Console.WriteLine($"Operand One: {operandOne}");
            Console.WriteLine($"Operand Two: {operandTwo}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Result: {result} \n");
            Console.ResetColor();

            return result;
        }
    }
}
