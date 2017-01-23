using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem06BinarySearchTree
{
    public class BinarySearchTree<T> : ICloneable, IEnumerable<T> where T : IComparable<T>
    {
        /// <summary>
        /// The root of the tree
        /// </summary>
        private BinaryTreeNode<T> root;
        /// <summary>
        /// Used for string representation of the tree
        /// </summary>
        private StringBuilder strRepresentation;
        /// <summary>
        /// Constructs the tree
        /// </summary>
        public BinarySearchTree()
        {
            this.root = null;
        }

        /// <summary>
        /// Inserts new value in the binary search tree
        /// </summary>
        /// <param name="value">the value to be inserted</param>
        public void Insert(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.root = Insert(value, null, root);
        }

        /// <summary>
        /// Removes an element from the tree if exists
        /// </summary>
        /// <param name="value">the value to be deleted</param>
        public void Remove(T value)
        {
            BinaryTreeNode<T> nodeToDelete = Find(value);
            if (nodeToDelete == null)
            {
                return;
            }
            Remove(nodeToDelete);
        }

        /// <summary>
        /// Finds a given value in the tree and returns the node
        /// which contains it if such exsists
        /// </summary>
        /// <param name="value">the value to be found</param>
        /// <returns>the found node or null if not found</returns>
        public BinaryTreeNode<T> Find(T value)
        {
            BinaryTreeNode<T> node = this.root;
            while (node != null)
            {
                int compareTo = value.CompareTo(node.Value);
                if (compareTo < 0)
                {
                    node = node.LeftChild;
                }
                else if (compareTo > 0)
                {
                    node = node.RightChild;
                }
                else
                {
                    break;
                }
            }
            return node;
        }

        /// <summary>
        /// Inserts node in the binary search tree by given value
        /// </summary>
        /// <param name="value">the new value</param>
        /// <param name="parentNode">the parent of the new node</param>
        /// <param name="node">current node</param>
        /// <returns>the inserted node</returns>
        private BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
                node.Parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.Value);
                if (compareTo < 0)
                {
                    node.LeftChild =
                    Insert(value, node, node.LeftChild);
                }
                else if (compareTo > 0)
                {
                    node.RightChild =
                    Insert(value, node, node.RightChild);
                }
            }
            return node;
        }

        private void Remove(BinaryTreeNode<T> node)
        {
            // Case 3: If the node has two children.
            // Note that if we get here at the end
            // the node will be with at most one child
            if (node.LeftChild != null && node.RightChild != null)
            {
                BinaryTreeNode<T> replacement = node.RightChild;
                while (replacement.LeftChild != null)
                {
                    replacement = replacement.LeftChild;
                }
                node.Value = replacement.Value;
                node = replacement;
            }
            // Case 1 and 2: If the node has at most one child
            BinaryTreeNode<T> theChild = node.LeftChild != null ?
            node.LeftChild : node.RightChild;
            // If the element to be deleted has one child
            if (theChild != null)
            {
                theChild.Parent = node.Parent;
                // Handle the case when the element is the root
                if (node.Parent == null)
                {
                    root = theChild;
                }
                else
                {
                    // Replace the element with its child subtree
                    if (node.Parent.LeftChild == node)
                    {
                        node.Parent.LeftChild = theChild;
                    }
                    else
                    {
                        node.Parent.RightChild = theChild;
                    }
                }
            }
            else
            {
                // Handle the case when the element is the root
                if (node.Parent == null)
                {
                    root = null;
                }
                else
                {
                    // Remove the element - it is a leaf
                    if (node.Parent.LeftChild == node)
                    {
                        node.Parent.LeftChild = null;
                    }
                    else
                    {
                        node.Parent.RightChild = null;
                    }
                }
            }
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            strRepresentation = new StringBuilder();
            PrintInorder(this.root);
            return strRepresentation.ToString();
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            BinarySearchTree<T> tree = obj as BinarySearchTree<T>;

            if ((System.Object)tree == null)
            {
                return false;
            }
            else
            {
                if (String.Compare(this.ToString(), tree.ToString()) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Gethashcode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int result = 1;

            foreach (char ch in this.ToString())
            {
                result ^= (int)ch;
            }

            return result;
        }

        /// <summary>
        /// Used in to string method
        /// </summary>
        /// <param name="root"></param>
        private void PrintInorder(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            // 1. Visit the left child
            PrintInorder(root.LeftChild);
            // 2. Visit the root of this subtree
            strRepresentation.Append(root.Value + " ");
            // 3. Visit the right child
            PrintInorder(root.RightChild);
        }

        /// <summary>
        /// IClonable implementation
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            BinarySearchTree<T> newTree = new BinarySearchTree<T>();
            BinaryTreeNode<T> node = (BinaryTreeNode<T>)this.root.Clone();
            newTree.root = node;
            return newTree;
        }

        /// <summary>
        /// operator ==
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(BinarySearchTree<T> t1, BinarySearchTree<T> t2)
        {
            return (t1.Equals(t2));
        }

        /// <summary>
        /// operator !=
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator !=(BinarySearchTree<T> t1, BinarySearchTree<T> t2)
        {
            return !(t1 == t2);
        }

        /// <summary>
        /// Traverses the list
        /// </summary>
        /// <param name="Node">The node to start the search from</param>
        /// <returns>The individual items from the tree</returns>
        private IEnumerable<BinaryTreeNode<T>> Traversal(BinaryTreeNode<T> Node)
        {
            if (Node.LeftChild != null)
            {
                foreach (BinaryTreeNode<T> LeftNode in Traversal(Node.LeftChild))
                    yield return LeftNode;
            }
            yield return Node;
            if (Node.RightChild != null)
            {
                foreach (BinaryTreeNode<T> RightNode in Traversal(Node.RightChild))
                    yield return RightNode;
            }
        }

        /// <summary>
        /// IEnumerable implementation
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (BinaryTreeNode<T> TempNode in Traversal(root))
            {
                yield return TempNode.Value;
            }
        }

        /// <summary>
        /// IEnumerable implementation
        /// </summary>
        /// <returns></returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

