using MobileMessaging.Send.Common.Enums;
using MobileMessaging.Send.Common.Settings;
using MobileMessaging.Send.Vendor;
using MobileMessaging.Send.Vendors;

namespace MobileMessaging.Send.Factories
{
    public static class VendorFactory
    {
        public static IVendor Create(
            VendorType type,
            VendorConnectionSettings _connectionSettings)
        {
           switch (type) {
                case VendorType.MessageNet:
                    return new MessageNetVendor(_connectionSettings);
                case VendorType.Twilio:
                    return new TwilioVendor(_connectionSettings);
                case VendorType.BulkSMS:
                    return new BulkSmsVendor(_connectionSettings);
                default:
                    throw new NotImplementedException();


            }
        }   

    }
}
