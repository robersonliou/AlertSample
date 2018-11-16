using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertSample.Decorator;

namespace AlertSample.Concrete
{
    public class SMSAlerterDecorator : AlerterDecorator
    {
        public SMSAlerterDecorator(IAlerter alerter) : base(alerter)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"[SMS] : {message}");
        }
    }
}
