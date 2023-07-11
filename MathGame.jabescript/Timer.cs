using System.Diagnostics;

namespace MathGame.jabescript;
public class Timer
{
    public void TimerMethod()
    {
        var startTime = Stopwatch.GetTimestamp();
        Console.WriteLine("hello!");
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        var newElapsed = string.Format("{0:00}:{1:00}", elapsedTime.Minutes, elapsedTime.Seconds);
        Console.WriteLine(newElapsed);
    }
}