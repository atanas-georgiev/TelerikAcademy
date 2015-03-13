using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    public class TimerEventArgs : EventArgs
    {
        public TimerEventArgs(int s)
        {
            interval = s;
        }
        private int interval;

        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }
    }

    /// <summary>
    /// Problem 8.*
    /// Read in MSDN about the keyword event in C# and how to publish events.
    /// Re-implement the above using .NET events and following the best practices.
    /// </summary>
    class TimerEvents
    {
        private int interval;
        private System.Timers.Timer timer;

        public event EventHandler<TimerEventArgs> RaiseTimerEvent;

        public TimerEvents(int seconds)
        {
            timer = new System.Timers.Timer(seconds * 1000);
            interval = seconds;
        }

        public void Start()
        {
            timer.Start();
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            OnRaiseTimerEvent(new TimerEventArgs(interval));
        }

        public void Stop()
        {
            timer.Stop();            
        }

        protected virtual void OnRaiseTimerEvent(TimerEventArgs e)
        {
            EventHandler<TimerEventArgs> handler = RaiseTimerEvent;

            if (handler != null)
            {
                e.Interval =  interval;
                handler(this, e);
            }
        }
    }
}
