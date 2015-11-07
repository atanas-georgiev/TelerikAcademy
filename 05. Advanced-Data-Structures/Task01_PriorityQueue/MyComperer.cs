namespace Task01_PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class MyComperer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}
