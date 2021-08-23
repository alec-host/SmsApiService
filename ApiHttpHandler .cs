using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    class ApiHttpHandler 
    {
        readonly IApiPostInterface apiPostInterface;
        public ApiHttpHandler(IApiPostInterface apiPostInterface)
        {
            this.apiPostInterface = apiPostInterface;
        }
        /*
        @method: SmsService.
        Param[s]: @json: string
        */
        public async Task<string> SmsService(string json)
        {
            await Task.Run(()=>{
                Console.Out.WriteLine(json);
                //-.Routine call.
                string serverResponse = apiPostInterface.SendSms("msisdn", "message");
                //-.Publish 3rd-party sms providers response to mq.
                new MessageQueueService().SmsServerResponsePub(serverResponse);
                Task.Delay(100).Wait();

                return serverResponse;
            });

            return "END_SMS_SERVICE";
        }
    }
}
