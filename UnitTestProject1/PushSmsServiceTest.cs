using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PUSH_SMS_SERVICE;

namespace UnitTestProject1
{
    [TestClass]
    public class PushSmsServiceTest
    {
        [TestMethod]
        public void AdditionTest()
        {
            Program program = new Program();

            int number1 = 10;
            int number2 = 5;

            int check = program.Addition(number1, number2);

            Assert.AreEqual(15, check);
        }
    }
}
