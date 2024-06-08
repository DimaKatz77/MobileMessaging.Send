using MobileMessaging.Send.Common.Enums;
namespace MobileMessaging.Send.Common.Lib.Base
{
    public abstract class BaseMobileMessageDto
    {
        protected BaseMobileMessageDto(string accountKey, string connectorId)
        {
            AccountKey = accountKey;
            ConnectorId = connectorId;
        }

        public string AccountKey { get; }

        public string ConnectorId { get; }


       

    }
}
