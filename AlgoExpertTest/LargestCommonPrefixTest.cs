using AlgoExpert;
using FluentAssertions;
using NUnit.Framework;
using System.Collections;

namespace AlgoExpertTest
{
    public class LargestCommonPrefixTest
    {
        [TestCaseSource(typeof(UseCases))]
        public void TestCases(string[] strs, string expectedResult)
        {
            LargestCommonPrefixProblem solution = new LargestCommonPrefixProblem();
            var output = solution.LongestCommonPrefix(strs);
            Assert.AreEqual(output, expectedResult);
        }

        private class UseCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new string[] { "flowers", "fleet", "flow"}, "fl" };
                yield return new object[] { new string[] { "flowers", "fleet", "flight" }, "fl" };
                yield return new object[] { new string[] { "dog", "dogcar", "car" }, string.Empty };
                yield return new object[] { new string[] { "Drool", "Drool", "Drool" }, "Drool" };
                yield return new object[] { new string[] { "#instagram", "#facebook", "#twitter" }, "#" };
                yield return new object[] { new string[] { "ab", "a"}, "a" };

            }
        }
    }
}
