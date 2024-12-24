using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailSenders.src.OopPrinciples.Coupling;

public class EmailSender : NotificationService
{
    public void SendNotification(string message)
    {
        //Email sending logic
        System.Console.WriteLine("Sending email: " + message );
    }
}
