using RPN_Calculator.BLL;
using RPN_Calculator.Test.Test_Data;

namespace RPN_Calculator.Test
{
    public class RPNCalculatorTests
    {
        
        [Theory]
        [ClassData(typeof(ExpressionListTestData))]
        public void Calculate_RpnExpressionOperation_ReturnsCorrectResult(ExpressionOperationTestData data)
        {

            Calculator calculator = new Calculator();

            decimal result = Calculator.Calculate(data.Expression);

            Assert.Equal(data.ExpectedResult, result);
        }

        [Theory]
        [ClassData(typeof(SquareRootListTestData))]
        public void Calculate_SquareRootOperation_ReturnsCorrectResult(SquareRootTestData data)
        {
            

            double result = Calculator.PerformSquareRootOperation(data.Number);

            Assert.Equal(data.ExpectedResult, result);
        }


    }
}
