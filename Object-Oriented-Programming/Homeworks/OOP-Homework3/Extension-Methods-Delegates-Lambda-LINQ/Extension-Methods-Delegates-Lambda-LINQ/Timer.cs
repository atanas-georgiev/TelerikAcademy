using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    /// <summary>
    /// Problem 7. Timer
    /// Using delegates write a class Timer that can execute certain method at each t seconds.
    /// </summary>
    class Timer
    {
        System.Timers.Timer timer;

        public delegate void MyMethodsDelegate();
        private MyMethodsDelegate funcs;

        public Timer(int seconds)
        {
            timer = new System.Timers.Timer(seconds * 1000);

        }

        public void Start()
        {
            timer.Start();
            timer.Elapsed += timer_Elapsed;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (funcs != null)
            {
                funcs();
            }
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void AddDelegate(MyMethodsDelegate d)
        {
            funcs += d;
        }
    }
}
