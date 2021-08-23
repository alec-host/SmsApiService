namespace PUSH_SMS_SERVICE
{
    interface IMessageQueuePubInterface
    {
        void SmsServerResponsePub(string serverResponse);
    }

    interface IMessageQueueSubInterface
    {
        string SmsNotificationSub();
    }
}
