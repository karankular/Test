using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;
using VM;

namespace UT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Output = new StringWriter();
            Console.SetOut(Output);
            var input = new StringReader(@"0.1");
            Console.SetIn(input);
            var a = Program.GetCoin();
            Assert.AreEqual(0.1, a);
        }

        [TestMethod]
        public void TestMethod2()
        {
          

            //var mock = new Mock<IVM>();

            //mock.Setup(f => f.GetCoin()).Returns()
        }
    }
}
