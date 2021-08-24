using System;

namespace PUSH_SMS_SERVICE
{
    class BulkSmsService : IApiPostInterface
    {
        public string SendSms(string msisdn, string textSms)
        {
            //throw new NotImplementedException();

            return "SENT_SMS";
        }
    }
}
