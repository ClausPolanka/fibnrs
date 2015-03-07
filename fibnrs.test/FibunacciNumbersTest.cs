using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace fibnrs.test
{
    [TestFixture]
    public class FibunacciNumbersTest
    {
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(19, 4181)]
        [TestCase(28, 317811)]
        [TestCase(36, 14930352)]
        [TestCase(38, 39088169)]
        public void Get_Fibunacci_number_for_given_index(int index, int expectedFibunacciNumber)
        {
            var sut = new FibunacciNumbers();
            var fibNr = sut.GetFibunacciNumber(index);
            Assert.That(fibNr, Is.EqualTo(expectedFibunacciNumber), "fib nr["+ index + "]");
        }
    }
}
