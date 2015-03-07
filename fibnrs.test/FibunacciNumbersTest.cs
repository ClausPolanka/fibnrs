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
        [Test]
        public void Get_first_Fibunacci_number()
        {
            var sut = new FibunacciNumbers();
            var fibNr = sut.GetFibunacciNumber(index: 1);
            Assert.That(fibNr, Is.EqualTo(0), "fib nr["+ 1 + "]: " + fibNr);
        }
    }
}
