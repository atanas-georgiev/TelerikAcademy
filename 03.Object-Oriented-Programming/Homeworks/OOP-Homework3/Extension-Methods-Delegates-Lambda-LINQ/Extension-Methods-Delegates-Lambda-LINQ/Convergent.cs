using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    class Convergent
    {
        public static double ConvergentSum(Func<int, double> termValue, double precision)
        {
            double result = 0;
            int element = 0;

            while (true)
            {
                double res = termValue(element);
                result += res;
                if (res < precision)
                    break;
                element++;
            }

            return result;
        }
    }
}
