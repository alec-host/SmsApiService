using System;
using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunAsConsoleAsync();
            Console.In.ReadLine();
        }

        private static async void RunAsConsoleAsync()
        {
            //-.read sms command from mq.
            string payload = await MqConsumer();
            //-..
            payload = "{'phoneNumber':'254721110000','smsText': 'test message'}";
            //-.send sms.
            string serverResponse = await InvokeSmsSend(payload);
            //-.publish server response.
            MqPublisher(serverResponse);
        }

        public static async Task<string> MqConsumer()
        {
            //-.DI using constructor injection.
            IMessageQueueSubInterface messageQueueService = new MessageQueueService();
            //-.read mq sms command.
            string payload = await new SmsCommandService(messageQueueService).GetSmsCommand();

            return payload;
        }

        public static void MqPublisher(string serverResponse) {
            if (serverResponse != null || serverResponse != "")
            {
                //-.Publish 3rd-party sms providers response to mq.
                new MessageQueueService().SmsServerResponsePub(serverResponse);
            }
        }

        public static async Task<string> InvokeSmsSend(string payload)
        {
            string serverResponse = String.Empty;
            if (payload != "" || payload == null)
            {
                Payload newPayload = new Payload();
                newPayload.Text = payload;
                //-.DI using constructor injection.
                IApiPostInterface bulkSmsService = new BulkSmsService();
                //-.http post.
                serverResponse = await new ApiHttpHandler(bulkSmsService).SmsService(newPayload);
            }
            return serverResponse;
        }
        /*
        simple test calc. 
        */
        public int Addition(int number1, int number2)
        {
            int result = (number1 + number2);

            return result;
        }
    }
}
