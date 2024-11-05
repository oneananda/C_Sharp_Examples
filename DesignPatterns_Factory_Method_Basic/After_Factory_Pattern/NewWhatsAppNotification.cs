﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Factory_Method_Basic.After_Factory_Pattern
{
    public class NewWhatsAppNotification : INewNotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending WhatsApp: {message}");
        }
    }
}