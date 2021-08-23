using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("start section");
            RunAsConsoleAsync();
            Console.In.ReadLine();
        }

        private static async void RunAsConsoleAsync()
        {
            //-.DI using constructor injection.
            ApiPostInterface bulkSmsService = new BulkSmsService();
            //-..
            string response = await new ApiHttpHandler(bulkSmsService).SmsService("input value");
            Console.Out.WriteLine(response);
        }
        /*
        test method 1. 
        */
        public int Addition(int number1, int number2)
        {
            int result = (number1 + number2);

            return result;
        }

    }
}
