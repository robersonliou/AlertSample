using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertSample.Decorator;

namespace AlertSample.Concrete
{
    public class MailAlerterDecorator : AlerterDecorator
    {

        public MailAlerterDecorator(IAlerter alerter) : base(alerter)
        {
        }

        public override void Notify(string message)
        {
            _alerter.Notify(message);
            Console.WriteLine($"[Mail] : {message}");
        }
        
    }
}
