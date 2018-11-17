using System;
using AlertSample.Concrete;

namespace AlertSample.Factory
{
    public static class SimpleAlerterFactory
    {
        public static IAlerter CreateAlerter(string systemCode)
        {
            switch (systemCode)
            {
                case "A":
                    return new LogAlerter();
                case "B":
                    return new MailAlerterDecorator(new LogAlerter());
                case "C":
                    return new SMSAlerterDecorator( new MailAlerterDecorator(new LogAlerter()));
                default:
                    throw new Exception("Not Support System Code Exception");
            }
        }
    }
}
