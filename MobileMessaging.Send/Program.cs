using MobileMessaging.Send.Common.Enums;
using MobileMessaging.Send.Common.Lib.QueueMessages;
using MobileMessaging.Send.Common.Settings;
using MobileMessaging.Send.Factories;

public class Programm
{
    static async Task Main(string[] args)
    {
        //Init Settings

        Console.WriteLine(">>>> Welcome <<<<<");

        //Init  MessageNet Logic
        Console.WriteLine("> Select a SMS provider");

        Console.WriteLine("> 1 - MessageNet");

        Console.WriteLine("> 2 - Twilio ");

        Console.WriteLine("> 3 - BulkSMS");

        int smsType = Convert.ToInt32(Console.ReadLine());

        var factory =  VendorFactory.Create((VendorType)smsType, new VendorConnectionSettings());

        factory.SendSMS();
        

    }


}