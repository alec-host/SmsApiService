using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    class SmsCmdService
    {
        //-.DI using setter.
        public IMessageQueueSubInterface MessageQueueInterface { get; set; }

        public async Task GetSms()
        {
            await Task.Run(() => {
                //-.Routine call.
                MessageQueueInterface.SmsNotificationSub();

                Task.Delay(50).Wait();
            });
        }
    }
}
