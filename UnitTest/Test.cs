using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace UnitTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Add_1Plus2Returned3()
        {
            double actual = MyMath.Add(1, 2);
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void Div_4Div2Returned2()
        {
           double actual = MyMath.Div(4, 2);
            Assert.AreEqual(2, actual);
        }


        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_4Div0ZeroException()
        {
           double actual = MyMath.Div(4, 0);           
        }
        
        [Test]
        [Ignore("12")]
        public void Test1()
        {
           double actual = MyMath.Div(4, 0);           
        }

    }
}
