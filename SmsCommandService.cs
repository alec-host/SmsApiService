using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    class SmsCommandService
    {
        //-.DI using constructor injection.
        readonly IMessageQueueSubInterface MessageQueueSubInterface;
        public SmsCommandService(IMessageQueueSubInterface messageQueueSubInterface)
        {
            this.MessageQueueSubInterface = messageQueueSubInterface;
        }
        public async Task<string> GetSmsCommand()
        {
            await Task.Run(() => {
                //-.Routine call.
                string cmd = MessageQueueSubInterface.SmsNotificationSub();

                Task.Delay(50).Wait();

                return cmd;
            });

            return "END_SMS_SERVICE";
        }
    }
}
