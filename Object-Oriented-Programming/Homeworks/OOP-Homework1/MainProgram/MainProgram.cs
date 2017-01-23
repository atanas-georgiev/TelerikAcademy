using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProgram
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("GSMTest -> ");
                GSMTest.Test();
                Console.WriteLine("CallHistoryTest -> ");
                CallHistoryTest.Test();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
