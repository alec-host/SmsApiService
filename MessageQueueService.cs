using System;

namespace PUSH_SMS_SERVICE
{
    class MessageQueueService : IMessageQueuePubInterface,IMessageQueueSubInterface
    {
        public string SmsNotificationSub()
        {
            //throw new NotImplementedException();
            Console.WriteLine("SMS COMMAND SUB");
            return "No implemented";
        }

        public void SmsServerResponsePub(string serverResponse)
        {
            if (serverResponse != null)
            {
                Console.Out.WriteLine("PUB METHOD");
            }
            //throw new System.NotImplementedException();
        }
    }
}