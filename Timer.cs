using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Timer
{
    public sealed class Whatcher
    {
        public EventHandler WhatcherEvent;
        public void AddClock(Clock clock)
        {
            clock.ClockEvent += ClockReceivedEvent;
        }

        private void ClockReceivedEvent(object? sender, EventArgs e)
        {
            WhatcherEvent.Invoke(this, EventArgs.Empty);
        }

    }

    public sealed class Clock
    {
        public EventHandler ClockEvent;
        public int timeTimer;
        public void AddWhatcher(Whatcher whatcher)
        {
            whatcher.WhatcherEvent += WhatcherReceivedEvent;
        }

        private void WhatcherReceivedEvent(object? sender, EventArgs e)
        {
            --timeTimer;
            if (timeTimer == 0)
            {
                Console.WriteLine("Time is over");
                return;
            }
            
            Console.WriteLine($"Timer: {timeTimer}");
            Thread.Sleep(1000);
            Console.Clear();
            ClockEvent.Invoke(this, EventArgs.Empty);
        }
    }

}
