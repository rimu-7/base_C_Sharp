using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Abstractions;

public class EmailServic
{
    public void SendEmail()
    {
        Connect();
        Authenticate();
        System.Console.WriteLine("Sending email....");
        Disconnecting();  
    }
    private void Connect()
    {
        System.Console.WriteLine("Connecting to the email server....");
    }
    private void Authenticate()
    {
        System.Console.WriteLine("Authenticating.....");
    }
    private void Disconnecting(){
        System.Console.WriteLine("Disconnecting from the email server.....");
    }

}
