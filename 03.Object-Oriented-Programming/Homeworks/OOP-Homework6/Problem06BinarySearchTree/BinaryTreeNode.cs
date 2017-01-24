using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem06BinarySearchTree
{
    /// <summary>
    /// Represents a binary tree node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>>, ICloneable where T : IComparable<T>
    {
        /// <summary>
        /// Constructs the tree node
        /// </summary>
        /// <param name="value">The value of the tree node</param>
        public BinaryTreeNode(T value)
        {
            this.Value = value;
            this.Parent = null;
            this.LeftChild = null;
            this.RightChild = null;
        }

        // Contains the value of the node
        public T Value { get; set; }
        // Contains the parent of the node
        public BinaryTreeNode<T> Parent { get; set; }
        // Contains the left child of the node
        public BinaryTreeNode<T> LeftChild { get; set; }
        // Contains the right child of the node
        public BinaryTreeNode<T> RightChild { get; set; }

        /// <summary>
        /// ICloneable implementation
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            BinaryTreeNode<T> clone = new BinaryTreeNode<T>(Value);

            if (LeftChild != null)
                clone.LeftChild = (BinaryTreeNode<T>)LeftChild.Clone();
            else
                clone.LeftChild = null;

            if (RightChild != null)
                clone.RightChild = (BinaryTreeNode<T>)RightChild.Clone();
            else
                clone.RightChild = null;

            return clone;
        }
        
        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[" + this.Value + "]"; ;
        }

        /// <summary>
        /// GetHashCode override
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        /// <summary>
        /// Equals override
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;
            return this.CompareTo(other) == 0;
        }

        /// <summary>
        /// IComparable implementation
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(BinaryTreeNode<T> other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}
