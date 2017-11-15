using System;
using System.Collections.Generic;

namespace StructuralPatterns.Singleton
{
    public class ReadOnlyThreadSafeLogger
    {
        private static readonly ReadOnlyThreadSafeLogger instance = new ReadOnlyThreadSafeLogger();
        private List<LogEvent> Logs;

        protected ReadOnlyThreadSafeLogger()
        {
            this.Logs = new List<LogEvent>();
        }

        public static ReadOnlyThreadSafeLogger Instance()
        {
            return instance;
        }

        public void Log(string message)
        {
            instance.Logs.Add(new LogEvent(message));
        }

        public void PrintLog()
        {
            try
            {
                ///sometimes it throws null argument exception (the instance is null...)
                ///that's why there is a try catch block, but not sure why it is happening

                foreach (var log in instance.Logs)
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
