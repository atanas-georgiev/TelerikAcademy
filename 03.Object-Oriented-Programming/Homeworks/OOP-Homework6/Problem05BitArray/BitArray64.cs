//Problem 5. 64 Bit array

//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem05BitArray
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong bitArray;
        public BitArray64()
        {
            bitArray = 0;
        }

        public bool this[int index]
        {
            get
            {
                if (index > 31)
                {
                    throw new ArgumentException();
                }

                if ((int)((bitArray >> index) & 1) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    bitArray |= ((ulong)1 << index);
                }
                else
                {
                    bitArray &= ~((ulong)1 << index);
                }
            }
        }

        public BitArray64(string value)
        {
            bitArray = 0;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                bitArray += (ulong)((int.Parse(value[i].ToString())) * Math.Pow(2, value.Length - i - 1));
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            ulong bitArrayTemp = bitArray;

            while (bitArrayTemp != 0)
            {
                result.Append(bitArrayTemp % 2);
                bitArrayTemp /= 2;
            }

            char[] ch = result.ToString().ToArray();
            Array.Reverse(ch);
            return new string(ch);
        }

        public override bool Equals(object obj)
        {
            BitArray64 arr = obj as BitArray64;

            if ((System.Object)arr == null)
            {
                return false;
            }
            else
            {
                return arr.bitArray == this.bitArray;                    
            }
        }

        public override int GetHashCode()
        {
            return (int)this.bitArray;
        }

        public static bool operator ==(BitArray64 arr1, BitArray64 arr2)
        {
            return arr1.Equals(arr2);
        }

        public static bool operator !=(BitArray64 arr1, BitArray64 arr2)
        {
            return !(arr1 == arr2);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 31; i >= 0; i--)
            {
                yield return (int)((bitArray >> i) & 1);
            };
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
