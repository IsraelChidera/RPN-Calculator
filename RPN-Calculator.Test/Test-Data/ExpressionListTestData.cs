using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_Calculator.Test.Test_Data
{
    public class ExpressionListTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new ExpressionOperationTestData { Expression = "5 3 +", ExpectedResult = 8 } };
            yield return new object[] { new ExpressionOperationTestData { Expression = "5 2 -", ExpectedResult = 3 } };
            yield return new object[] { new ExpressionOperationTestData { Expression = "10 3 *", ExpectedResult = 30 } };
            yield return new object[] { new ExpressionOperationTestData { Expression = "27 9 /", ExpectedResult = 3 } };
            yield return new object[] { new ExpressionOperationTestData { Expression = "5 3 4 + *", ExpectedResult = 35 } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
