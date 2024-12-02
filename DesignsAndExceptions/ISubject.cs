using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public interface ISubject
    {
        public void Notify(); // notifies all subscribers
        public void Register(ISubscriber subscriber); // add a subscriber to the list to be notified
        public void Unregister(ISubscriber subscriber); // removes a subscriber from the notification list
    }
}
