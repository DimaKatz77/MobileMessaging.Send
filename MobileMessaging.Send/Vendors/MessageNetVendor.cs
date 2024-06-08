using MobileMessaging.Send.Common.Enums;
using MobileMessaging.Send.Common.Lib.QueueMessages;
using MobileMessaging.Send.Common.Settings;
using MobileMessaging.Send.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMessaging.Send.Vendors
{
    public class MessageNetVendor : BaseVendor, IVendor
    {

        public MessageNetVendor(VendorConnectionSettings _connectionSettings) :
            base(_connectionSettings)
        { }

        public VendorType Type => VendorType.MessageNet;

        protected override string GetType => Type.ToString();

        protected override string VendorAuth()
        {
            return $"{GetType} Auth Success";
        }

    }
}
