﻿namespace Task03_WordsSet.PatriciaTree
{
    using System.Collections.Generic;
    using System.Linq;

    public class PatriciaSuffixTrie<TValue> : ITrie<TValue>
    {
        private readonly int m_MinQueryLength;
        private readonly PatriciaTrie<TValue> m_InnerTrie;

        public PatriciaSuffixTrie(int minQueryLength)
            : this(minQueryLength, new PatriciaTrie<TValue>())
        {
            
        }

        internal PatriciaSuffixTrie(int minQueryLength, PatriciaTrie<TValue> innerTrie)
        {
            this.m_MinQueryLength = minQueryLength;
            this.m_InnerTrie = innerTrie;
        }

        protected int MinQueryLength
        {
            get { return this.m_MinQueryLength; }
        }

        public IEnumerable<TValue> Retrieve(string query)
        {
            return
                this.m_InnerTrie
                    .Retrieve(query)
                    .Distinct();
        }

        public void Add(string key, TValue value)
        {
            IEnumerable<StringPartition> allSuffixes = GetAllSuffixes(this.MinQueryLength, key);
            foreach (StringPartition currentSuffix in allSuffixes)
            {
                this.m_InnerTrie.Add(currentSuffix, value);
            }
        }

        private static IEnumerable<StringPartition> GetAllSuffixes(int minSuffixLength, string word)
        {
            for (int i = word.Length - minSuffixLength; i >= 0; i--)
            {
                yield return new StringPartition(word, i);
            }
        }
    }
}