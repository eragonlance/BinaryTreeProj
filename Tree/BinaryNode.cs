using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                } else {
                    LeftNode.insert(val);
                }
            } else {
                if (RightNode == null) {
                    RightNode = new BinaryNode<T>(val);
                } else {
                    RightNode.insert(val);
                }
            }

            return true;
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

            if(!value.isLarger(val) && rightNode != null) {
                bool existVal = rightNode.remove(val, ref nodeToReplace, ref isRemoved);

                if (existVal && !isRemoved) {
                    rightNode = nodeToReplace;
                    isRemoved = true;
                }

                return existVal;
            }

            return false;
        }

        public void print(string indent, bool last) {
            Console.Write(indent);
            if (last) {
                Console.Write("\\-");
                indent += "  ";
            } else {
                Console.Write("|-");
                indent += "| ";
            }
            Console.WriteLine(Value.ToString());

            if (LeftNode != null) {
                LeftNode.print(indent, RightNode == null);
            }
            if (RightNode != null) {
                RightNode.print(indent, true);
            }
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
