namespace PUSH_SMS_SERVICE
{
    interface IApiPostInterface
    {
        string SendSms(string msisdn,string textSms);
    }
}
