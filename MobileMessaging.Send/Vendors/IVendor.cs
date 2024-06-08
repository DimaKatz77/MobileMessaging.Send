using MobileMessaging.Send.Common.Enums;

namespace MobileMessaging.Send.Vendor
{
    public interface IVendor
    {

        VendorType Type { get; }

        void  SendSMS();

    }
}
