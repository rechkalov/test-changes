using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testable.Tests
{
    [NUnit.Framework.TestFixture]
    public class CalcTests
    {
        [NUnit.Framework.Test]
        public void Add()
        {
            var calc = new Calc();
            var sum = calc.Add(1, 2);
            NUnit.Framework.Assert.AreEqual(3, sum);
        }
    }
}
