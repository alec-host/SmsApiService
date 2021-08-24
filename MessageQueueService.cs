using System;

namespace PUSH_SMS_SERVICE
{
    class MessageQueueService : IMessageQueuePubInterface,IMessageQueueSubInterface
    {
        public string SmsNotificationSub()
        {
            //throw new NotImplementedException();

            return "SMS_NOTIFICATION_SUB";
        }

        public void SmsServerResponsePub(string serverResponse)
        {
            //throw new System.NotImplementedException();

            Console.Out.WriteLine("3. PUBLISH SERVER RESPONSE FROM "+serverResponse);
        }
    }
}