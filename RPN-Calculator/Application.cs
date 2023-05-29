using RPN_Calculator.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
