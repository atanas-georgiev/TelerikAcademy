﻿namespace Task11
{
    class ListItem<T>
    {
        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }
    }
}
