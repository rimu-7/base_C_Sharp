using EmailSenders.src.OopPrinciples.Coupling;


var order = new Order(new SmsSender());

order.PlaceOrder();