using System;

namespace EmailSenders.src.OopPrinciples.Coupling;

public class SmsSender : NotificationService
{
    public void SendNotification(string message)
    {
        System.Console.WriteLine("SMS message: "+ message);
    }
}
