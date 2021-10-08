using AlgoExpert;
using NUnit.Framework;
using System.Collections;

namespace AlgoExpertTest
{
    public class RemoveDuplicatesSolutionTest
    {
        [TestCaseSource(typeof(UseCases))]
        public void TestCases(int[] n, int expected)
        {
            RemoveDuplicatesSolution solution = new RemoveDuplicatesSolution();
            var output = solution.RemoveDuplicates(n);
            Assert.AreEqual(output, expected);
        }

        private class UseCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new int[] { }, 0 };
                yield return new object[] { new int[] { 0, 0, 1 }, 2 };
                yield return new object[] { new int[] { 0, 0, 0 }, 1 };
                yield return new object[] { new int[] { 0, 1, 1, 2 }, 3 };
                yield return new object[] { new int[] { 0, 1, 2, 3 }, 4 };
            }
        }
    }
}
