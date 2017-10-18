using System.Collections.Generic;
using NUnit.Framework;

namespace PrimeFactorKata
{
    [TestFixture]
    public class PrimeFactorTests
    {
        [Test]
        public void Generate_WhenZero_EmptyList()
        {
            var result = PrimeFactor.GeneratePrime(0);
            Assert.That(result, Is.EqualTo(new int[] { }));
        }
    }

    public static class PrimeFactor
    {
        public static List<int> GeneratePrime(int number)
        {
            return new List<int>();
        }
    }
}
