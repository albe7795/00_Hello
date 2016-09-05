using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Hello
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHello()
        {
            Assert.AreEqual("hello", Intro.Hello());
        }
        [TestMethod]
        public void TestHelloFred()
        {
            Assert.AreEqual("hello, Fred", Intro.Hello("Fred"));
        }
    }

    internal class Intro
    {

    }
}
