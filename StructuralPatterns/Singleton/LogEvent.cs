using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Singleton
{
    public class LogEvent
    {
        public DateTime EventTime { get; set; }
        public string Message { get; set; }

        public LogEvent(string message)
        {
            this.EventTime = DateTime.Now;
            this.Message = message;
        }
    }
}
