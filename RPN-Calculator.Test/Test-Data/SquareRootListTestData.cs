using System.Collections;

namespace RPN_Calculator.Test.Test_Data
{
    public class SquareRootListTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new SquareRootTestData { Number = "25", ExpectedResult = 5 } };
            yield return new object[] { new SquareRootTestData { Number = "36", ExpectedResult = 6 } };
            yield return new object[] { new SquareRootTestData { Number = "16", ExpectedResult = 4 } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

