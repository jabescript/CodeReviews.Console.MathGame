using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.jabescript
{
    public class Timer
    {
        public void TimerMethod()
        {
            long startTime = Stopwatch.GetTimestamp();
            Console.WriteLine("hello!");
            TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
            string? newElapsed = string.Format("{0:00}:{1:00}", elapsedTime.Minutes, elapsedTime.Seconds);
            Console.WriteLine(newElapsed);
        }
    }
}
