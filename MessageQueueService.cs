using System;

namespace PUSH_SMS_SERVICE
{
    class MessageQueueService : IMessageQueuePubInterface,IMessageQueueSubInterface
    {
        public void SmsNotificationSub()
        {
            throw new NotImplementedException();
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