using System;

namespace EmailSenders.src.OopPrinciples.Coupling;

public interface NotificationService
{
    void SendNotification(string message);
}
