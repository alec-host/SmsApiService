using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    class ApiHttpHandler 
    {
        readonly IApiPostInterface apiPostInterface;
        //-.constructor.
        public ApiHttpHandler(IApiPostInterface apiPostInterface)
        {
            this.apiPostInterface = apiPostInterface;
        }
        /*
        @method: SmsService.
        Param[s]: @json: string
        */
        public async Task<string> SmsService(Payload payload)
        {
            Console.Out.WriteLine("2. apismshandler: SMS API SERVICE");
            try
            {
                //-.convert to object.
                var obj = JObject.Parse(payload.Text);

                await Task.Run(() =>
                {
                    //-.Routine call.
                    string serverResponse = apiPostInterface.SendSms(obj["phoneNumber"].ToString(), obj["smsText"].ToString());
                    //-.Publish 3rd-party sms providers response to mq.
                    new MessageQueueService().SmsServerResponsePub(serverResponse);

                    Task.Delay(100).Wait();

                    return serverResponse;
                });
            }
            catch (JsonReaderException e)
            {
                Console.Out.WriteLine(e.Message);
            }

            return "END_SMS_SERVICE";
        }
    }
}
