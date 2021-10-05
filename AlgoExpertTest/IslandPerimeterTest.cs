using NUnit.Framework;
using System.Collections;
using FluentAssertions;

namespace AlgoExpertTest
{
    public class IslandPerimeterTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(typeof(IslandTestCases))]
        public void TestBestCase(int[][] source, int returnVal)
        {
            // Act
            int perimeter = AlgoExpert.Solution.IslandPerimeter(source);

            perimeter.Should().Equals(returnVal);
        }

        private class IslandTestCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { new int[][] { new int[] { 1 } }, 4 };
                yield return new object[] { new int[][] { new int[] { 0 } }, 0 };
                yield return new object[] { new int[][] {
                    new int[] { 0, 1, 0, 0 },
                    new int[] { 1, 1, 1, 0 },
                    new int[] { 0, 1, 0, 0 },
                    new int[] { 1, 1, 0, 0 }
                }, 16
                };
            }
        }
    }
}