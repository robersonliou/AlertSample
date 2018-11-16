using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertSample
{
    public interface IAlerter
    {
        void Notify(string message);
    }

    public class LogAlerter : IAlerter
    {
        public void Notify(string message)
        {
            Console.WriteLine($"[Log] : {message}");
        }
    }
}
