namespace Utils.Shared
{
    public class Utils
    {
        public static void Line()
        {
            Console.WriteLine("**********************************" +
                "**********************");
        }

        public static void ErrorPrompts(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{message}\n");
            Console.ResetColor();
        }
    }
}