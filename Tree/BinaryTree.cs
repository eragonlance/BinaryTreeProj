using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace BinaryTreeProj.Tree {
    class BinaryTree<T> : Subject<BinaryTree<T>> where T : INodeType<T> {
        private BinaryNode<T> root = null;
        private Bitmap nodeCanvas = new Bitmap(64, 64);
        private Font font = new Font("Verdana", 20);
        private Pen pen = new Pen(Color.Black, 1.5f);

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

        ///<summary>insert a node, return false if node already existed</summary>
        public bool insert(T val) {
            if (isEmpty()) {
                root = new BinaryNode<T>(val);
                notify();
                return true;
            }

            var isInserted = root.insert(val);
            if (isInserted) {
                notify();
            }
            return isInserted;
        }

        ///<summary>insert a range of nodes, return false if they all existed</summary>
        public bool insertRange(IEnumerable<T> vals) {
            if (vals.Count() < 1) {
                return false;
            }

            bool isInserted = false;

            if (isEmpty()) {
                root = new BinaryNode<T>(vals.First());
                isInserted = true;
            }

            foreach (var i in vals) {
                isInserted = root.insert(i) || isInserted;
            }

            if (isInserted) {
                notify();
            }

            return isInserted;
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
            return isEmpty() ? 0 : root.nRightOnly();
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
        public int pathLength(T node) {
            return isEmpty() ? 0 : root.pathLength(node);
        }

        ///<summary>find node with designated value</summary>
        public bool find(T val) {
            return root == null ? false : root.find(val);
        }

        ///<summary>find node with the largest value</summary>
        public T findLargest() {
            return isEmpty() ? default(T) : root.findLargest();
        }

        ///<summary>find node with the smallest value</summary>
        public T findSmallest() {
            return isEmpty() ? default(T) : root.findSmallest();
        }

        ///<summary>find node with the largest value on left subtree </summary>
        public T findLeftLargest() {
            return isEmpty() || root.LeftNode == null ? default(T) : root.LeftNode.findLargest();
        }

        ///<summary>find node with the smallest value on right subtree</summary>
        public T findRightSmallest() {
            return isEmpty() || root.RightNode == null ? default(T) : root.RightNode.findSmallest();
        }

        ///<summary>remove a node with designated value</summary>
        public bool remove(T val) {
            if (isEmpty()) {
                return false;
            }

            BinaryNode<T> nodeToReplace = null;
            bool isRemoved = false;
            bool existVal = root.remove(val, ref nodeToReplace, ref isRemoved);

            if (existVal && !isRemoved) {
                root = nodeToReplace;
            }

            if (existVal) {
                notify();
            }

            return existVal;
        }

        ///<summary>check if tree is empty</summary>
        public bool isEmpty() {
            return root == null;
        }

        ///<summary>empty this tree</summary>
        public void clear() {
            root = null;
            notify();
        }

        ///<summary>draw tree to an image</summary>
        public Image draw(T highlightedNode) {
            int connect;
            var distance = new Size(nodeCanvas.Width / 4, nodeCanvas.Height);
            return root == null ? null : root.Draw(nodeCanvas, font, pen, distance, out connect, highlightedNode);
        }

        public BinaryTree() {
            var g = Graphics.FromImage(nodeCanvas);
            g.SmoothingMode = SmoothingMode.HighQuality;
            var ellipseFrame = new Rectangle(1, 1, nodeCanvas.Width - 2, nodeCanvas.Height - 2);
            g.FillEllipse(Brushes.LightGreen, ellipseFrame);
            g.DrawEllipse(pen, ellipseFrame);
        }

        public BinaryTree(IEnumerable<T> nodes) : this() {
            if (nodes.Count() > 0) {
                root = new BinaryNode<T>(nodes.First());

                foreach (var i in nodes) {
                    root.insert(i);
                }
            }
        }
    }
}
