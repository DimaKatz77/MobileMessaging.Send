using MobileMessaging.Send.Common.Enums;
using MobileMessaging.Send.Common.Lib.Base;

namespace MobileMessaging.Send.Common.Lib.QueueMessages
{
    public class MobileMessageDto : BaseMobileMessageDto
    {
        public MobileMessageDto(
            string accountKey, 
            string connectorId) : base(accountKey, connectorId)
        {
        }

        public string Message { get; }

        public string FromPhoneNumber { get; }

        public string ToPhoneNumber { get; }
    }
}
