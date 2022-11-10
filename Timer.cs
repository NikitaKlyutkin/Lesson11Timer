using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Timer
{
    public sealed class Whatcher
    {

        public void AddClock(Clock clock)
        {
            clock.ClockEvent += ClockReceivedEvent;
        }

        private void ClockReceivedEvent(object? sender, string e)
        {
            Console.WriteLine(e);
        }

    }

    public sealed class Clock
    {
        public EventHandler<string> ClockEvent;

        public void StartClock(int timeTimer)
        {
            while (timeTimer > 0)
            {
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.Clear();
                ClockEvent.Invoke(this, $"Timer: {timeTimer}");
                timeTimer--;
            }
            Console.Clear();
            ClockEvent.Invoke(this, $"Time is over");
        }
    }

}
