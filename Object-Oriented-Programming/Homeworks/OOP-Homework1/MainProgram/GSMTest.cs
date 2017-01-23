using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProgram
{
    class GSMTest
    {
        public static void Test()
        {
            GSM[] gsms = new GSM[3];
            gsms[0] = new GSM("Lumia 720", "Nokia", 100, "Pesho", 4.3, 16000000, "Samsung", 100, 100, Battery.BatteryType.NiCd);
            gsms[1] = new GSM("Lumia 930", "Nokia", 600, "Pesho", 5, 16000000, "Samsung", 200, 300, Battery.BatteryType.NiCd);
            gsms[2] = new GSM("Iphone 6", "Apple", 100, "Gosho", 5.5, 16000000, "Apple", 100, 100, Battery.BatteryType.LiIon);

            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine(gsms[i]);
            }

            Console.WriteLine("Iphone 4 static informarmation: " + GSM.IPhone4s);
        }
    }
}
