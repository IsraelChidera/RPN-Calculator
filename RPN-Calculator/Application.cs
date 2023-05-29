using RPN_Calculator.BLL;
using Utils.Shared;

namespace RPN_Calculator
{
    public class Application
    {
        public static void Run()
        {
            Menu.Header();

            Calculator.OperationsMenu();
        }
    }
}
