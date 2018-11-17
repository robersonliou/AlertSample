using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertSample.Concrete;
using AlertSample.Factory;

namespace AlertSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alerter需依照傳入的system code決定告警策略
            //系統A - Log
            //系統B - Log + Mail
            //系統C - Log + Mail + SMS

            var systemCode = "A";

            //使用工廠方法得到對應的Logger
            IAlerter alerter = SimpleAlerterFactory.CreateAlerter(systemCode);
            //var alerter = new MailAlerterDecorator(new LogAlerter());
            try
            {
                //simulate exception
                throw new Exception("Database connection timeout.");
            }
            catch (Exception e)
            {
                alerter.Notify(e.Message);
            }

            Console.Read();
        }
    }
}
