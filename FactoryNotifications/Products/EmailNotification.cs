using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryNotifications.Products
{
    public class EmailNotification : INotification
    {

        public void Send(string message)
        {
            Console.WriteLine($"Sending message by email: {message}");
        }
    }
}
