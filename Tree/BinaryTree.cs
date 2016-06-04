using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree {
    class BinaryTree<T> where T : INodeType<T> {
        private BinaryNode<T> root = null;

        ///<summary>get all values of this tree in String, visit L-N-R by default</summary>
        public IEnumerable<String> getAllValues(BinTreeVisitor visitor = null) {
            if (isEmpty()) {
                return Enumerable.Empty<String>();
            }

            if (visitor == null) {
                visitor = LNRVisitor.get();
            }

            return visitor.visit(root).Select(x => x.ToString());
        }

        public bool insert(T node) {
            if (isEmpty()) {
                root = new BinaryNode<T>(node);
                return true;
            }

            return root.insert(node);
        }

        ///<summary>count leaf nodes</summary>
        public int countLeafNodes() {
            return isEmpty() ? 0 : root.countLeafNodes();
        }

        ///<summary>count nodes with only a single subtree</summary>
        public int nSingleOnly() {
            return isEmpty() ? 0 : root.nSingleOnly();
        }

        ///<summary>count nodes with only right subtree</summary>
        public int nRightOnly() {
            return isEmpty() ? 0 : root.countLeafNodes();
        }

        ///<summary>count nodes with only left subtree</summary>
        public int nLeftOnly() {
            return isEmpty() ? 0 : root.nLeftOnly();
        }

        ///<summary>count nodes with both subtrees</summary>
        public int nBoth() {
            return isEmpty() ? 0 : root.nBoth();
        }

        ///<summary>return total height of the tree</summary>
        public int getHeight() {
            return isEmpty() ? 0 : root.getHeight();
        }

        ///<summary>count all nodes in the tree</summary>
        public int countNodes() {
            return isEmpty() ? 0 : root.countNodes();
        }

        ///<summary>count all nodes on a depth of the tree</summary>
        public int countNodesOnDepth(int depth) {
            return isEmpty() ? 0 : root.countNodesOnDepth(depth);
        }

        ///<summary>length of the path from root node to "n" node</summary>
        public int pathLength(T node, int recursiveDepth = 0) {
            return isEmpty() ? 0 : root.pathLength(node);
        }

        ///<summary>find node with the largest value</summary>
        public T findLargest() {
            return isEmpty() ? default(T) : root.findLargest();
        }

        ///<summary>find node with the smallest value</summary>
        public T findSmallest() {
            return isEmpty() ? default(T) : root.findSmallest();
        }

        bool isEmpty() {
            return root == null;
        }

        public void print() {
            if (isEmpty()) {
                return;
            }

            root.print("", true);
        }

        public BinaryTree() { }

        public BinaryTree(IEnumerable<T> nodes) {
            if (nodes.Count() > 0) {
                root = new BinaryNode<T>(nodes.First());

                foreach (var i in nodes) {
                    root.insert(i);
                }
            }
        }
    }
}
