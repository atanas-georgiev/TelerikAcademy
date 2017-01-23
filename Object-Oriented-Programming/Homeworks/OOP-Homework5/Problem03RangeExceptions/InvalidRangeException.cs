using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
            where T : IComparable<T>
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end, Exception e)
            : base(String.Format("{0}\nParameter should be in range[{1}; {2}]", message, start, end), e)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null) { }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null) { }


        public T Start
        {
            get { return start; }
            set { start = value; }
        }

        public T End
        {
            get { return end; }
            set { end = value; }
        }
    }
}
