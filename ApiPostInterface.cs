using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    interface ApiPostInterface
    {
        string SendSms(string msisdn,string textSms);
    }
}
