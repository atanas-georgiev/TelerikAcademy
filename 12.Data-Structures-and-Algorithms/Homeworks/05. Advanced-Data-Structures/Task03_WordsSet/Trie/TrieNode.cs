namespace Task03_WordsSet.Trie
{
    using System;
    using System.Collections.Generic;

    public class TrieNode<TValue> : TrieNodeBase<TValue>
    {
        private readonly Dictionary<char, TrieNode<TValue>> m_Children;
        private readonly Queue<TValue> m_Values;

        protected TrieNode()
        {
            this.m_Children = new Dictionary<char, TrieNode<TValue>>();
            this.m_Values = new Queue<TValue>();
        }

        protected override int KeyLength
        {
            get { return 1; }
        }

        protected override IEnumerable<TrieNodeBase<TValue>> Children()
        {
            return this.m_Children.Values;
        }

        protected override IEnumerable<TValue> Values()
        {
            return this.m_Values;
        }

        protected override TrieNodeBase<TValue> GetOrCreateChild(char key)
        {
            TrieNode<TValue> result;
            if (!this.m_Children.TryGetValue(key, out result))
            {
                result = new TrieNode<TValue>();
                this.m_Children.Add(key, result);
            }
            return result;
        }

        protected override TrieNodeBase<TValue> GetChildOrNull(string query, int position)
        {
            if (query == null) throw new ArgumentNullException("query");
            TrieNode<TValue> childNode;
            return
                this.m_Children.TryGetValue(query[position], out childNode)
                    ? childNode
                    : null;
        }

        protected override void AddValue(TValue value)
        {
            this.m_Values.Enqueue(value);
        }
    }
}