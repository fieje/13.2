using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class MathExpressionTest
    {
        [TestMethod]
        public void TestMathExpression()
        {
            float x = 2;
            float y = 3;
            float z = 12;
            float expectedResult = Math.Max((float)Math.Pow(x, 3), (float)Math.Pow((x + y), 2));

            float result = CalculateMathExpression(x, y, z);

            Assert.AreEqual(expectedResult, result);
        }


        private float CalculateMathExpression(float x, float y, float z)
        {
            float numerator, denominator;

            if (z > 10)
            {
                numerator = Math.Max((float)Math.Pow(x, 3), (float)Math.Pow((x + y), 2));
            }
            else
            {
                numerator = 0;
            }

            if (z <= 10)
            {
                denominator = Math.Min(Math.Abs(x - 2), Math.Abs(x + z));
            }
            else
            {
                denominator = 1;
            }

            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }

            return numerator / denominator;
        }
    }
}
