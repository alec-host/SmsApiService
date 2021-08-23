﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSH_SMS_SERVICE
{
    class Program
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
            string response = await new HttpHandle(bulkSmsService).SmsService("input value");
            Console.Out.WriteLine(response);
        }
    }
}
