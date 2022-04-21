using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reverse_Polish_Calculation;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Polish_Calculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(Calculator.Calculate("2 3 +"), "5");
        }

        [TestMethod]
        public void Comutativity()
        {
            Assert.AreEqual(Calculator.Calculate("3 2 +"), "5");
        }

        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(Calculator.Calculate("3 2 -"), "1");
        }

        [TestMethod]
        public void SubractFlipped()
        {
            Assert.AreEqual(Calculator.Calculate("2 3 -"), "-1");
        }

        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(Calculator.Calculate("4 5 *"), "20");
        }

        [TestMethod]
        public void ComutativityMultiply()
        {
            Assert.AreEqual(Calculator.Calculate("5 4 *"), "20");
        }

        [TestMethod]
        public void Divide()
        {
            Assert.AreEqual(Calculator.Calculate("9 3 /"), "3");
        }

        [TestMethod]
        public void DivideFlipped()
        {
            Assert.AreEqual(Calculator.Calculate("3 9 /"), (3.0/9.0).ToString());
        }

        [TestMethod]
        public void MultipleOperations()
        {
            Assert.AreEqual(Calculator.Calculate("5 8 6 3 + * -"), "-67");
        }

        [TestMethod]
        public void MultipleOperations2()
        {
            Assert.AreEqual(Calculator.Calculate("5 8 + 6 3 * -"), "-5");
        }

        [TestMethod]
        public void MultipleOperations3()
        {
            Assert.AreEqual(Calculator.Calculate("5 8 6 + 3 * -"), "-37");
        }

        [TestMethod]
        public void MultipleOperations4()
        {
            Assert.AreEqual(Calculator.Calculate("5 8 + 6 * 3 -"), "75");
        }

        [TestMethod]
        public void MultipleOperations5()
        {
            Assert.AreEqual(Calculator.Calculate("5 8 6 + * 3 -"), "67");
        }

    }
}
