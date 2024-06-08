using MobileMessaging.Send.Common.Enums;
using MobileMessaging.Send.Common.Lib.QueueMessages;
using MobileMessaging.Send.Common.Settings;
using MobileMessaging.Send.Vendor;
using System.Reflection.Metadata.Ecma335;

namespace MobileMessaging.Send.Vendors
{
    public class BulkSmsVendor : BaseVendor, IVendor
    {

        public BulkSmsVendor(VendorConnectionSettings _connectionSettings): 
            base(_connectionSettings) { }

        public VendorType Type =>  VendorType.BulkSMS;

        protected override string GetType => Type.ToString() ;

        protected override string VendorAuth()
        {
            return $"{GetType} Auth Success";
        }
    }
}
