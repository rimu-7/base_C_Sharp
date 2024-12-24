using System;

namespace Solid.src.S;

public class EmailSender
{
    public void SendEmail(string email, string message)
    {
        System.Console.WriteLine($"Sending email to {email}: {message}");
    }

}
