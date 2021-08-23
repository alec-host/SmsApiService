namespace PUSH_SMS_SERVICE
{
    class PublishServerResponseHandler
    {
        //-.DI using setter.
        public IMessageQueuePubInterface MessageQueueInterface { get; set; }

        public void Pub(string response)
        {
            MessageQueueInterface.SmsServerResponsePub(response);
        }
    } 
}
