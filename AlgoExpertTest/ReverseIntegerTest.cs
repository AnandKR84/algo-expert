using AlgoExpert;
using FluentAssertions;
using NUnit.Framework;
using System.Collections;

namespace AlgoExpertTest
{
    public class ReverseIntegerTest
    {
        [TestCaseSource(typeof(UseCases))]
        public void TestCases(int x, int reversed)
        {
            ReverseInteger revInteger = new ReverseInteger();
            int returned = revInteger.Reverse(x);
            Assert.AreEqual(reversed, returned);
        }

        private class UseCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { 123, 321 };
                yield return new object[] { -123, -321 };
                yield return new object[] { 120, 21 };
                yield return new object[] { 1534236469, 0 };
            }
        }
    }
}
