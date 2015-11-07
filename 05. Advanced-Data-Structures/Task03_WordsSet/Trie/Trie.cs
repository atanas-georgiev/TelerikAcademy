namespace Task03_WordsSet.Trie
{
    using System.Collections.Generic;

    public class Trie<TValue> : TrieNode<TValue>, ITrie<TValue>
    {
        public IEnumerable<TValue> Retrieve(string query)
        {
            return this.Retrieve(query, 0);
        }

        public void Add(string key, TValue value)
        {
            this.Add(key, 0, value);
        }
    }
}