using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using cal.Func;
using System.ComponentModel;

namespace UnitTestProject1
{
    [TestClass]
    public class SimpleMethods
    {
        [TestMethod]
        public void TestAreEqual()
        {
            Add add = new Add("10", "5");
            Assert.AreEqual(15, add.Result);
        }
        [TestMethod]
        public void TestAreEqual2()
        {
            Sub sub = new Sub("1", "0");
            Add add = new Add("1", "0");
            Assert.AreEqual(sub.Result, add.Result);
        }
        [TestMethod]
        public void TestAreNotEqual()
        {
            Div div = new Div("10", "5");
            Assert.AreNotEqual(15, div.Result);
        }
        [TestMethod]
        public void TestIsTrue()
        {
            Root root = new Root("9");
            Assert.IsTrue(3 == root.Result);
        }
        [TestMethod]
        public void TestIsFalse()
        {
            Root root = new Root("9");
            Assert.IsFalse(4 == root.Result);
        }
        [TestMethod]
        public void TestIsInstanceOfType()
        {
            Mul mul = new Mul("2", "5");
            Assert.IsInstanceOfType(mul.Result, typeof(double?));
        }
        [TestMethod]
        public void TestIsNotInstanceOfType()
        {
            Mul mul = new Mul("2", "5");
            Assert.IsNotInstanceOfType(mul.Result, typeof(int));
        }
        [TestMethod]
        public void TestIsNotNull()
        {
            Sub sub = new Sub("1", "0");
            Assert.IsNotNull(sub.Result);
        }
        [TestMethod]
        public void TestIsNull()
        {
            Sub sub = new Sub("", "");
            Assert.IsNull(sub.Result);
        }
        [TestMethod]
        public void TestAreNotSame()
        {
            Sub sub = new Sub("0", "1");
            Add add = new Add("0", "1");
            Assert.AreNotSame(add.Result, sub.Result);
        }
    }
    [TestClass]
    public class ComplexMethods
    {
        [TestMethod]
        public void TestThrowsException1()
        {
            Sub sub = new Sub("www", "1");
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => sub.Result));
        }
        [TestMethod]
        public void TestThrowsException2()
        {
            Mul mul = new Mul("900000000000000000000000000000000000000000", "1");
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => mul.Result));
        }
        [TestMethod]
        public void TestThrowsException3()
        {
            Root root = new Root("-10");
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => root.Result));
        }
        [TestMethod]
        public void TestThrowsException4()
        {
            Div div = new Div(null, null);
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => div.Result));
        }
        [TestMethod]
        public void TestThrowsException5()
        {
            Add add = new Add(int.MinValue.ToString(), int.MinValue.ToString());
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => add.Result));
        }
    }
}
