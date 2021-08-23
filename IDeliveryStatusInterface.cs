namespace PUSH_SMS_SERVICE
{
    interface IDeliveryStatusInterface
    {
        string GetSmsStatus(string messageReferenceNumber);
    }
}
