using AlgoExpert;
using FluentAssertions;
using NUnit.Framework;
using System.Collections;

namespace AlgoExpertTest
{
    class ClimbingStairsTest
    {
        [TestCaseSource(typeof(ClimbingStairsUseCases))]
        public void TestBestCase(int noOfStairs, int noOfWays)
        {
            ClimbingStairs stairs = new ClimbingStairs();
            var ways = stairs.ClimbStairs(noOfStairs);
            ways.Should().Equals(noOfWays);
        }

        private class ClimbingStairsUseCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { 2, 2 };
                yield return new object[] { 3, 3 };
                yield return new object[] { 4, 5 };
                yield return new object[] { 5, 8 };
            }
        }
    }    
}
