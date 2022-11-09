using Lesson11Timer;

Whatcher whatcher = new Whatcher();
Clock clock = new Clock();
clock.timeTimer = 15;
whatcher.AddClock(clock);
clock.AddWhatcher(whatcher);
whatcher.WhatcherEvent.Invoke(null, EventArgs.Empty);
