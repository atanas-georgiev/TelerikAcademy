﻿namespace Task03_WordsSet.PatriciaTree
{
    public struct SplitResult
    {
        private readonly StringPartition m_Head;
        private readonly StringPartition m_Rest;

        public SplitResult(StringPartition head, StringPartition rest)
        {
            this.m_Head = head;
            this.m_Rest = rest;
        }

        public StringPartition Rest
        {
            get { return this.m_Rest; }
        }

        public StringPartition Head
        {
            get { return this.m_Head; }
        }

        public bool Equals(SplitResult other)
        {
            return this.m_Head == other.m_Head && this.m_Rest == other.m_Rest;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is SplitResult && this.Equals((SplitResult) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (this.m_Head.GetHashCode()*397) ^ this.m_Rest.GetHashCode();
            }
        }

        public static bool operator ==(SplitResult left, SplitResult right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(SplitResult left, SplitResult right)
        {
            return !(left == right);
        }
    }
}