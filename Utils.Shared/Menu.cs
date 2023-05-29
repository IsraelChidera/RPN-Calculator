namespace Utils.Shared
{
    public class Menu
    {
        public static void Header()
        {
            Utils.Line();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tReverse Polish Notation (RPN) calculator");
            Console.ResetColor();
            Utils.Line();
        }

        public static void CalculatorMainMenu()
        {
            Console.WriteLine("What do you want?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                    "\tPress 1: To make a simple calculation using operators\n"
                    + "\tPress 2: To get the square root of a number\n"
                    + "\tPress 0: To exit"
            );
            Console.ResetColor();

        }


    }
}
