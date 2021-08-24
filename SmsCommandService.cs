using System;
using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    class SmsCommandService
    {
        //-.DI using constructor injection.
        readonly IMessageQueueSubInterface MessageQueueSubInterface;
        //-.constructor.
        public SmsCommandService(IMessageQueueSubInterface messageQueueSubInterface)
        {
            this.MessageQueueSubInterface = messageQueueSubInterface;
        }
        /*
        @method: GetSmsCommand.
        Param[s]: none.
        */
        public async Task<string> GetSmsCommand()
        {
            Console.Out.WriteLine("1. getsmscommand SUBSCRIBER");
            await Task.Run(() => {
                //-.Routine call.
                string cmd = MessageQueueSubInterface.SmsNotificationSub();

                Task.Delay(50).Wait();

                return cmd;
            });

            return "END_READ_SMS_COMMAND";
        }
    }
}
