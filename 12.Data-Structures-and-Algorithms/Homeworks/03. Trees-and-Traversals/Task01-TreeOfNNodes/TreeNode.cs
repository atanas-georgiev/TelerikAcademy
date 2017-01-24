namespace Task01_TreeOfNNodes
{
    using System;
    using System.Collections.Generic;

    public class TreeNode<T> where T : IComparable
    {
        private readonly List<TreeNode<T>> children;

        private bool hasParent;

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            this.hasParent = false;
            this.Value = value;
            this.children = new List<TreeNode<T>>();
        }

        public T Value { get; set; }

        public bool HasParent
        {
            get
            {
                return this.hasParent;
            }
        }

        public List<TreeNode<T>> Children
        {
            get
            {
                return this.children;
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("child");
            }

            if (child.hasParent)
            {
                throw new ArgumentException("child.hasParent");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
    }
}