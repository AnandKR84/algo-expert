using AlgoExpert;
using FluentAssertions;
using NUnit.Framework;
using System.Collections;

namespace AlgoExpertTest
{
    public class TwoSumTest
    {
        [TestCaseSource(typeof(TwoSumTestUseCases))]
        public void TestCases(int[] numbers, int target, int[] indices)
        {
            TwoSumSolution twoSum = new TwoSumSolution();
            var output = twoSum.TwoSum(numbers, target);
            _ = output.Should().BeEquivalentTo(indices);
        }

        private class TwoSumTestUseCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 } };
                yield return new object[] { new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 } };
            }
        }
    }
}
