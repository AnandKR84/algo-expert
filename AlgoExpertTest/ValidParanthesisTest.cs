using AlgoExpert;
using FluentAssertions;
using NUnit.Framework;
using System.Collections;

namespace AlgoExpertTest
{
    public class ValidParanthesisTest
    {
        [TestCaseSource(typeof(UseCases))]
        public void TestCases(string s, bool expected)
        {
            ValidParanthesisProblem solution = new ValidParanthesisProblem();
            bool output = solution.IsValid(s);
            Assert.AreEqual(output, expected);
        }

        private class UseCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { "()", true };
                yield return new object[] { "({})", true };
                yield return new object[] { "({)}", false };
                yield return new object[] { "(}", false };
                yield return new object[] { "", true };
                yield return new object[] { "()[]{}", true };
                yield return new object[] { "(", false };
                yield return new object[] { ")(", false };
            }
        }
    }
}
