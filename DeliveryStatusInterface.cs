namespace PUSH_SMS_SERVICE
{
    interface DeliveryStatusInterface
    {
        string GetSmsStatus(string messageReferenceNumber);
    }
}
