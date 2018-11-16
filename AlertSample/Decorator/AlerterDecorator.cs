using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertSample.Decorator
{
    public abstract  class AlerterDecorator : IAlerter
    {
        protected readonly IAlerter _alerter;

        protected AlerterDecorator(IAlerter alerter)
        {
            _alerter = alerter;
        }

        public abstract void Notify(string message);

    }
}
