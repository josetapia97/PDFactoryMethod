using FactoryNotifications.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryNotifications.Factories.ConcreteFactories
{
    public class SMSNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}
