using FactoryNotifications;
using FactoryNotifications.Factories;
using FactoryNotifications.Factories.ConcreteFactories;


Console.WriteLine("Welcome to Notification module");
Console.WriteLine("Using Factory Method");

while (true)
{
    Console.WriteLine("\nPlease choose a notification type: (1) Email ,(2) SMS ,(3) Push ,(4) Quit ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    NotificationFactory plantillaNoti = null;
    if (opcion >=1 && opcion <= 3) 
    { 
        switch (opcion)
        {
            case 1:
                plantillaNoti = new EmailNotificationFactory();
                break;
            case 2:
                plantillaNoti = new SMSNotificationFactory();
                break;
            case 3:
                plantillaNoti = new PushNotificationFactory();
                break;
        }
        INotification noti = plantillaNoti.CreateNotification();
        noti.Send("User was created succesfully");


    }else if(opcion == 4)
    {
        Console.WriteLine("Thanks for use the app :)");
        break;
    }
    else {
        Console.WriteLine($"Invalid option: {opcion}");
    };
}