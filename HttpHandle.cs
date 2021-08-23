using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    class HttpHandle 
    {
        ApiPostInterface apiPostInterface;
        public HttpHandle(ApiPostInterface apiPostInterface)
        {
            this.apiPostInterface = apiPostInterface;
        }
        /*
        @method: SmsService.
        Param[s]: @json: string
        */
        public async Task<string> SmsService(string json)
        {
            string serverResponse;
            await Task.Run(()=>{
                Console.Out.WriteLine(json);
                //-.routine call.
                serverResponse = apiPostInterface.SendSms("", "");
                Task.Delay(150).Wait();
            });

            return "END_SERVICE";
        }
    }
}
