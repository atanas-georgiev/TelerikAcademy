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
        //  MyMethodsDelegate foobar = new MyMethodsDelegate(RunMyMethod);

        System.Timers.Timer timer;

        public delegate void MyMethodsDelegate();

        public Timer(int seconds)
        {
            timer = new System.Timers.Timer(seconds);
        }
        
        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

    //    public AddDelegateMethod(MyMethodsDelegate method)
    //    {
    //        timer.Elapsed += method;
    //    }
    //
    }
}
