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
        [TestMethod]
        public void ConsumerMqValueTest()
        {

            var payload = Program.MqConsumer();

            Assert.IsNotNull(payload);
        }
        [TestMethod]
        public void SmsServiceTest()
        {
            var command = "{'phoneNumber':'254721110000','smsText': 'test message'}";
            var serverResponse = Program.InvokeSmsSend(command);

            Assert.AreNotEqual(serverResponse, "");
        }
        [TestMethod]
        public void SmsServiceMockTest()
        {
            Mock<Program.InvokeSmsSend> mock = new Mock<Program.InvokeSmsSend>;
            var command = "{'phoneNumber':'254721110000','smsText': 'test message'}";
            var serverResponse = Program.InvokeSmsSend(command);

            Assert.AreNotEqual(serverResponse, "");
        }
    }
}
