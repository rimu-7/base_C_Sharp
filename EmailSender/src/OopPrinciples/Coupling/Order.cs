using System;

namespace EmailSenders.src.OopPrinciples.Coupling;

public class Order

{
    private readonly NotificationService notificationService;


    public Order(NotificationService notificationService, EmailSender emailSender)
    {
        this.notificationService = notificationService;
    }
    public void PlaceOrder()
    {
        notificationService.SendNotification("Order placed successfully.");
    }
}
