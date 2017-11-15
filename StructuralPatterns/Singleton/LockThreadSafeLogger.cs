using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Singleton
{
    public class LockThreadSafeLogger
    {
        private static LockThreadSafeLogger instance; 
        private List<LogEvent> Logs;
        private static object syncRoot = new object();

        protected LockThreadSafeLogger()
        {
            this.Logs = new List<LogEvent>();
        }

        public static LockThreadSafeLogger Instance()
        {
            if (instance == null)
            {
                //when using lock on a SAME object for all thread, there is NO chance that more 
                //than one thread will go into the lock statement at the same time.
                //https://stackoverflow.com/questions/9621438/confusion-about-the-lock-statement-in-c-sharp
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new LockThreadSafeLogger();
                    }
                }
            }

            return instance;
        }

        public void Log(string message)
        {
            instance.Logs.Add(new LogEvent(message));
        }

        public void PrintLog()
        {
            foreach (var log in instance.Logs)
            {
                Console.WriteLine(log.Message + " at time " + log.EventTime);
            }
        }
    }

}
