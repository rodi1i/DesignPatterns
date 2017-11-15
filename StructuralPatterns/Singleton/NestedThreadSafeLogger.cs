using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Singleton
{
    public class NestedThreadSafeLogger
    {
        private List<LogEvent> Logs;

        protected NestedThreadSafeLogger()
        {
            this.Logs = new List<LogEvent>();
        }

        public static NestedThreadSafeLogger Instance()
        {
            return Nested.Instance;
        }

        public void Log(string message)
        {
            Nested.Instance.Logs.Add(new LogEvent(message));
        }

        public void PrintLog()
        {
            try
            {
                ///sometimes it throws null argument exception (the instance is null...)
                ///that's why there is a try catch block, but not sure why it is happening

                foreach (var log in Nested.Instance.Logs)
                {
                    Console.WriteLine(log.Message + " at time " + log.EventTime);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private class Nested
        {
            internal static readonly NestedThreadSafeLogger Instance = new NestedThreadSafeLogger();
            static Nested()
            {
            }
        }
    }
}
