using System;
using System.Collections;
using NUnit.Framework;

namespace Open_Lab_04._03
{
    [TestFixture]
    public class Tests
    {

        private StringTools tools;

        private const int RandStrMinSize = 1;
        private const int RandStrMaxSize = 15;
        private const int RandSeed = 403403403;
        private const int RandTestCasesCount = 95;

        [OneTimeSetUp]
        public void Init() => tools = new StringTools();

        [TestCase("hello", "ell")]
        [TestCase("maybe", "ayb")]
        [TestCase("benefit", "enefi")]
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCaseSource(nameof(GetRandom))]
        public void RemoveFirstLastTest(string str, string expected) =>
            Assert.That(tools.RemoveFirstLast(str), Is.EqualTo(expected));

        private static IEnumerable GetRandom()
        {
            var rand = new Random(RandSeed);

            for (var i = 0; i < RandTestCasesCount; i++)
            {
                var arr = new char[rand.Next(RandStrMinSize, RandStrMaxSize + 1)];

                for (var j = 0; j < arr.Length; j++)
                    arr[j] = (char) rand.Next('a', 'z' + 1);

                yield return new TestCaseData(new string(arr), new string(arr.Length > 1 ? arr[1..^1] : arr));
            }
        }

    }
}
