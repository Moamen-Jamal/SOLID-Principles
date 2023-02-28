//var customers = SOLID.DIP.Before.Repository.Customers;

//foreach (var customer in customers)
//{
//    var notificationService = new SOLID.DIP.Before.NotificationService(customer);
//    notificationService.Notify();
//}

var customers = SOLID.DIP.Before.Repository.Customers;
foreach (var customer in customers)
{
    var messageService = new List<SOLID.DIP.After.IMessageService>
    {
                    new SOLID.DIP.After.EmailService {EmailAddress = customer.EmailAddress },
                    new SOLID.DIP.After.SMSService {MobileNo = customer.MobileNo },
                    new SOLID.DIP.After.MailService {Address = customer.Address}
                };

    // constructor injection
    var notificationService = new SOLID.DIP.After.NotificationService(messageService);
    //notificationService.Notify();

    // property injection
    var notificationService1 = new SOLID.DIP.After.NotificationService1();
    notificationService1.SetServices(messageService);
    //notificationService1.Notify();
    // method injection
    var notificationService2 = new SOLID.DIP.After.NotificationService2();
    notificationService2.Notify(messageService);

}

Console.ReadKey();
