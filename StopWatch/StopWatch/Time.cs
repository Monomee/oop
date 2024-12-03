using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Time
    {
        private DateTime startTime;
        private DateTime endTime;

        public Time()
        {
        }

        public DateTime StartTime {get { return startTime; } }
        public DateTime EndTime {get { return endTime; } }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public long GetElapsedTime()
        {
            return (long)(endTime - startTime).TotalMilliseconds ;
        }
    }
}
