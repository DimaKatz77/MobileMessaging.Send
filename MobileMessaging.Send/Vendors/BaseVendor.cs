using MobileMessaging.Send.Common.Lib.QueueMessages;
using MobileMessaging.Send.Common.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMessaging.Send.Vendors
{
    public abstract class BaseVendor
    {
        protected VendorConnectionSettings _connectionSettings;

        protected MobileMessageDto _messageData;

        protected BaseVendor(VendorConnectionSettings connectionSettings)
        {
            _connectionSettings = connectionSettings;
        }

        protected abstract string VendorAuth();

        public void Init(MobileMessageDto data)
        {
            _messageData = data;
        }

        protected abstract string GetType { get; }

        public void SendSMS()
        {
            string authResult = VendorAuth();
            Console.WriteLine($"{authResult}");
            Console.WriteLine($"Start to send sms with {GetType} Vendor ");
        }

    }
}
