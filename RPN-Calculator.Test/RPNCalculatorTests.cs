using RPN_Calculator.BLL;
using RPN_Calculator.Test.Test_Data;

namespace RPN_Calculator.Test
{
    public class RPNCalculatorTests
    {
        /* [Theory]
         [InlineData("5 3 +", 8)]
         [InlineData("2 4 +", 6)]
         [InlineData("10 2 +", 12)]*/
        /*public void Calculate_RpnExpressionOperation_ReturnsCorrectResult(string expression, decimal expected)
        {
            
            Calculator calculator = new Calculator();
            
            decimal result = Calculator.Calculate(expression);

            Assert.Equal(expected, result);
        }*/
        [Theory]
        [ClassData(typeof(ExpressionListTestData))]
        public void Calculate_RpnExpressionOperation_ReturnsCorrectResult(ExpressionOperationTestData data)
        {

            Calculator calculator = new Calculator();

            decimal result = Calculator.Calculate(data.Expression);

            Assert.Equal(data.ExpectedResult, result);
        }
    }
}
