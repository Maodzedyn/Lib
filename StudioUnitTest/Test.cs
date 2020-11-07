using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudioUnitTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Add_1Plus2Returned3()
        {
            double actual = MyMath.Add(1, 2);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void Div_4Div2Returned2()
        {
            double actual = MyMath.Div(4, 2);
            Assert.AreEqual(2, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_4Div0ZeroException()
        {
            double actual = MyMath.Div(4, 0);
        }

        [TestMethod]
        [Ignore("12")]
        public void Test1()
        {
            double actual = MyMath.Div(4, 0);
        }

    }
}
