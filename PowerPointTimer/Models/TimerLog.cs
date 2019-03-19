using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPointTimer.Models
{
    class TimerLog
    {
        public static readonly List<TimerLog> Logs = new List<TimerLog>();

        public static void AddLog(TimeSpan duration) => Logs.Add(new TimerLog(Logs.Count + 1, duration));
        
        public static void ClearLogs() => Logs.Clear();
        
        public int Number { get; }
        public TimeSpan Duration { get; }

        public TimerLog(int number, TimeSpan duration)
        {
            Number = number;
            Duration = duration;
        }
    }
}
