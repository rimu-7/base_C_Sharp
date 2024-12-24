using System;

namespace Solid.src.S;

public class UserService
{
public void Register(User user){
        EmailSender sendemail = new EmailSender();
        sendemail.SendEmail(user.UserEmail, "Welcome to our platform.");

    }
}
