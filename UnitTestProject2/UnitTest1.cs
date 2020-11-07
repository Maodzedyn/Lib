using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StudLib;

namespace UnitTestProject2
{
        [TestClass]

        public class Class1

        {

            [TestMethod]

            public void TestRating()

            {

                Mock<ISubject> mock = new Mock<ISubject>();

                mock.Setup(f => f.AvgBal()).Returns(4);

                mock.Setup(f => f.SubjectName).Returns("Programming");

                Student s = new Student();

                double r = s.Rating(mock.Object);

                Assert.AreEqual(40, r);

            }
        }
}
