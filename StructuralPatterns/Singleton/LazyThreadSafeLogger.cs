using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Singleton
{
    public class LazyThreadSafeLogger
    {
        private static readonly Lazy<LazyThreadSafeLogger> lazy =
            new Lazy<LazyThreadSafeLogger>(() => new LazyThreadSafeLogger());

        private List<LogEvent> Logs;

        protected LazyThreadSafeLogger()
        {
            this.Logs = new List<LogEvent>();
        }

        public static LazyThreadSafeLogger Instance()
        {
            return lazy.Value;
        }

        public void Log(string message)
        {
            lazy.Value.Logs.Add(new LogEvent(message));
        }

        public void PrintLog()
        {
            try
            {
                ///sometimes it throws null argument exception (the instance is null...)
                ///that's why there is a try catch block, but not sure why it is happening

                foreach (var log in lazy.Value.Logs)
                {
                    Console.WriteLine(log.Message + " at time " + log.EventTime);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
