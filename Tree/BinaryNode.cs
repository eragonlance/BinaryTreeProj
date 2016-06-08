using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace BinaryTreeProj.Tree {
    class BinaryNode<T> where T : INodeType<T> {
        private T value = default(T);
        private BinaryNode<T> leftNode = null;
        private BinaryNode<T> rightNode = null;

        public T Value {
            get {
                return value;
            }

            set {
                this.value = value;
            }
        }

        public BinaryNode<T> LeftNode {
            get {
                return leftNode;
            }

            set {
                leftNode = value;
            }
        }

        public BinaryNode<T> RightNode {
            get {
                return rightNode;
            }

            set {
                rightNode = value;
            }
        }

        ///<summary>get all values of this tree in String</summary>
        public IEnumerable<String> getAllValues(BinTreeVisitor visitor) {
            if (visitor == null) {
                visitor = LNRVisitor.get();
            }

            return visitor.visit(this).Select(x => x.ToString());
        }

        public bool insert(T val) {
            if (this.value.Equals(val)) {
                return false;
            }

            if (this.value.isLarger(val)) {
                if (LeftNode == null) {
                    LeftNode = new BinaryNode<T>(val);
                    return true;
                } else {
                    return LeftNode.insert(val);
                }
            } else {
                if (RightNode == null) {
                    RightNode = new BinaryNode<T>(val);
                    return true;
                } else {
                    return RightNode.insert(val);
                }
            }
        }

        ///<summary>count leaf nodes</summary>
        public int countLeafNodes() {
            int leftCount = LeftNode == null ? 0 : LeftNode.countLeafNodes();
            int rightCount = RightNode == null ? 0 : RightNode.countLeafNodes();

            return (leftCount + rightCount) == 0 ? 1 : leftCount + rightCount;
        }

        ///<summary>count nodes with only a single subtree</summary>
        public int nSingleOnly() {
            int leftCount = LeftNode == null ? 0 : LeftNode.nSingleOnly();
            int rightCount = RightNode == null ? 0 : RightNode.nSingleOnly();

            return ((LeftNode == null) ^ (RightNode == null)) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        ///<summary>count nodes with only right subtree</summary>
        public int nRightOnly() {
            int leftCount = LeftNode == null ? 0 : LeftNode.nRightOnly();
            int rightCount = RightNode == null ? 0 : RightNode.nRightOnly();

            return (LeftNode == null) && (RightNode != null) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        ///<summary>count nodes with only left subtree</summary>
        public int nLeftOnly() {
            int leftCount = LeftNode == null ? 0 : LeftNode.nLeftOnly();
            int rightCount = RightNode == null ? 0 : RightNode.nLeftOnly();

            return (LeftNode != null) && (RightNode == null) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        ///<summary>count nodes with both subtrees</summary>
        public int nBoth() {
            int leftCount = LeftNode == null ? 0 : LeftNode.nBoth();
            int rightCount = RightNode == null ? 0 : RightNode.nBoth();

            return (LeftNode != null) && (RightNode != null) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        ///<summary>return total height of the tree</summary>
        public int getHeight() {
            int leftHeight = LeftNode == null ? 0 : LeftNode.getHeight();
            int rightHeight = RightNode == null ? 0 : RightNode.getHeight();

            return leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
        }

        ///<summary>count all nodes in the tree</summary>
        public int countNodes() {
            int leftCount = LeftNode == null ? 0 : LeftNode.countNodes();
            int rightCount = RightNode == null ? 0 : RightNode.countNodes();

            return leftCount + rightCount + 1;
        }

        ///<summary>count all nodes on a depth of the tree</summary>
        public int countNodesOnDepth(int depth, int recursiveDepth = 0) {
            if (depth < recursiveDepth) {
                return 0;
            }

            if (depth == recursiveDepth) {
                return 1;
            }

            int leftCount = LeftNode == null ? 0 : LeftNode.countNodesOnDepth(depth, recursiveDepth + 1);
            int rightCount = RightNode == null ? 0 : RightNode.countNodesOnDepth(depth, recursiveDepth + 1);
            return leftCount + rightCount;
        }

        ///<summary>length of the path from root node to "n" node</summary>
        public int pathLength(T val, int recursiveDepth = 0) {
            if (Value.Equals(val)) {
                return recursiveDepth;
            }

            if (Value.isLarger(val) && LeftNode != null) {
                return LeftNode.pathLength(val, recursiveDepth + 1);
            }

            if (!Value.isLarger(val) && RightNode != null) {
                return RightNode.pathLength(val, recursiveDepth + 1);
            }

            return -1;
        }

        ///<summary>find node with designated value</summary>
        public bool find(T val) {
            if (value.Equals(val)) {
                return true;
            }

            if (value.isLarger(val) && leftNode != null) {
                return leftNode.find(val);
            }

            if (!value.isLarger(val) && rightNode != null) {
                return rightNode.find(val);
            }

            return false;
        }

        ///<summary>find node with the largest value</summary>
        public T findLargest() {
            if (rightNode == null) {
                return value;
            }

            return rightNode.findLargest();
        }

        ///<summary>find node with the smallest value</summary>
        public T findSmallest() {
            if (leftNode == null) {
                return value;
            }

            return leftNode.findSmallest();
        }

        ///<summary>remove a node with designated value</summary>
        public bool remove(T val, ref BinaryNode<T> nodeToReplace, ref bool isRemoved) {
            if (value.Equals(val)) {
                if (rightNode == null) {
                    nodeToReplace = leftNode;
                } else {
                    bool tmp = false;
                    value = rightNode.removeSmallest(ref tmp);

                    if (!tmp) {
                        rightNode = null;
                    }

                    nodeToReplace = this;
                }

                return true;
            }

            if (value.isLarger(val) && leftNode != null) {
                bool existVal = leftNode.remove(val, ref nodeToReplace, ref isRemoved);

                if (existVal && !isRemoved) {
                    leftNode = nodeToReplace;
                    isRemoved = true;
                }

                return existVal;
            }

            if (!value.isLarger(val) && rightNode != null) {
                bool existVal = rightNode.remove(val, ref nodeToReplace, ref isRemoved);

                if (existVal && !isRemoved) {
                    rightNode = nodeToReplace;
                    isRemoved = true;
                }

                return existVal;
            }

            return false;
        }

        ///<summary>draw tree to an Image</summary>
        public Image Draw(Image nodeCanvas, Font font, Pen pen, Size distance, out int connect, T highlightedNode = default(T)) {
            var lConnect = 0;
            var rConnect = 0;

            Image lNodeImg = leftNode == null ? null : leftNode.Draw(nodeCanvas, font, pen, distance, out lConnect, highlightedNode);
            Image rNodeImg = rightNode == null ? null : rightNode.Draw(nodeCanvas, font, pen, distance, out rConnect, highlightedNode);

            var lSize = lNodeImg == null ? new Size((nodeCanvas.Width - distance.Width) / 2, 0) : lNodeImg.Size;
            var rSize = rNodeImg == null ? new Size((nodeCanvas.Width - distance.Width) / 2, 0) : rNodeImg.Size;

            var childImgHeight = lSize.Height > rSize.Height ? lSize.Height : rSize.Height;
            var resultImg = new Bitmap(
                lSize.Width + rSize.Width + distance.Width,
                nodeCanvas.Size.Height + (leftNode != null || rightNode != null ? childImgHeight + distance.Height : 0)
                );

            var g = Graphics.FromImage(resultImg);
            g.SmoothingMode = SmoothingMode.HighQuality;

            var nodeLocation = new Point(lSize.Width - (nodeCanvas.Width - distance.Width) / 2, 0);
            g.DrawImage(nodeCanvas, nodeLocation);

            if (highlightedNode != null && value.Equals(highlightedNode)) {
                g.FillEllipse(Brushes.Red, new Rectangle(nodeLocation.X + 1, nodeLocation.Y + 1, nodeCanvas.Width - 2, nodeCanvas.Height - 2));
            }

            using (var format = new StringFormat()) {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                g.DrawString(value.ToString(), font, Brushes.Black,
                    new Rectangle(
                    nodeLocation.X - nodeCanvas.Width, nodeLocation.Y, nodeCanvas.Width * 3, nodeCanvas.Height), format);
            }

            connect = lSize.Width + distance.Width / 2;

            if (lNodeImg != null) {
                g.DrawLine(pen, connect, nodeCanvas.Height, lConnect, nodeCanvas.Height + distance.Height);
                g.DrawImage(lNodeImg, 0, nodeCanvas.Size.Height + distance.Height);
            }

            if (rNodeImg != null) {
                g.DrawLine(pen, connect, nodeCanvas.Height, rConnect + lSize.Width + distance.Width, nodeCanvas.Height + distance.Height);
                g.DrawImage(rNodeImg, lSize.Width + distance.Width, nodeCanvas.Height + distance.Height);
            }

            return resultImg;
        }

        public BinaryNode(T val) {
            this.value = val;
        }

        //remove and return smallest node
        private T removeSmallest(ref bool isRemoved) {
            if (leftNode == null) {
                return value;
            }

            T smallest = leftNode.removeSmallest(ref isRemoved);

            if (!isRemoved) {
                leftNode = null;
                isRemoved = true;
            }

            return smallest;
        }
    }
}
