using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryNotifications
{
    public interface INotification
    {
        void Send(string message);
    }
}
