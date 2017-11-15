using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Singleton
{
    public class ThreadUnsafeLogger
    {
        private static ThreadUnsafeLogger instance;
        private List<LogEvent> Logs;
         
        protected ThreadUnsafeLogger()
        {
            this.Logs = new List<LogEvent>();
        }

        public static ThreadUnsafeLogger Instance()
        {
            if (instance == null)
            {
                instance = new ThreadUnsafeLogger();
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
