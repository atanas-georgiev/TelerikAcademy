using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProgram
{
    class CallHistoryTest
    {
        static public void Test()
        {
            GSM gsm = new GSM("Lumia 720", "Nokia", 100, "Pesho", 4.3, 16000000, "Nokia", 100, 100, Battery.BatteryType.LiIon);
            gsm.AddCall(DateTime.Now, "+359886554433", 60);
            gsm.AddCall(DateTime.Now, "+359886114433", 6);
            gsm.AddCall(DateTime.Now, "+359886224433", 12);
            gsm.AddCall(DateTime.Now, "+359886111111", 187);
            gsm.AddCall(DateTime.Now, "+359886222222", 786);

            Console.WriteLine("Calls:");

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("{0}, {1}, {2} seconds", call.DateTimeValue, call.Number, call.Duration);
            }

            Console.WriteLine();
            Console.WriteLine("Total price {0}", gsm.CalculateTotalCallsPrice(0.37));

            var index = gsm.CallHistory.Aggregate((i1, i2) => i1.Duration > i2.Duration ? i1 : i2);         
            gsm.RemoveCall(index);

            Console.WriteLine("Calls:");

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("{0}, {1}, {2} seconds", call.DateTimeValue, call.Number, call.Duration);
            }

            Console.WriteLine();
            Console.WriteLine("Total price {0}", gsm.CalculateTotalCallsPrice(0.37));

            gsm.ClearCalls();
        }
    }
}
