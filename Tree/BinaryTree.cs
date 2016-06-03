using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree {
    class BinaryTree<T> where T : NodeType<T> {
        protected T value = default(T);
        protected BinaryTree<T> leftSubTree = null;
        protected BinaryTree<T> rightSubTree = null;

        public bool insert(T val) {
            if (value.Equals(val)) {
                return false;
            }

            if (value.isLarger(val)) {
                if (leftSubTree == null) {
                    leftSubTree = new BinaryTree<T>(val);
                } else {
                    leftSubTree.insert(val);
                }
            } else {
                if (rightSubTree == null) {
                    rightSubTree = new BinaryTree<T>(val);
                } else {
                    rightSubTree.insert(val);
                }
            }

            return true;
        }

        public int countLeafNodes() {
            int leftCount = leftSubTree == null ? 0 : leftSubTree.countLeafNodes();
            int rightCount = rightSubTree == null ? 0 : rightSubTree.countLeafNodes();

            return (leftCount + rightCount) == 0 ? 1 : leftCount + rightCount;
        }

        public int countNodesWithSingleSubtree() {
            int leftCount = leftSubTree == null ? 0 : leftSubTree.countNodesWithSingleSubtree();
            int rightCount = rightSubTree == null ? 0 : rightSubTree.countNodesWithSingleSubtree();

            return ((leftSubTree == null) ^ (rightSubTree == null)) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        public int countNodesWithOnlyRightSubtree() {
            int leftCount = leftSubTree == null ? 0 : leftSubTree.countNodesWithOnlyRightSubtree();
            int rightCount = rightSubTree == null ? 0 : rightSubTree.countNodesWithOnlyRightSubtree();

            return (leftSubTree == null) && (rightSubTree != null) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        public int countNodesWithOnlyLeftSubTree() {
            int leftCount = leftSubTree == null ? 0 : leftSubTree.countNodesWithOnlyLeftSubTree();
            int rightCount = rightSubTree == null ? 0 : rightSubTree.countNodesWithOnlyLeftSubTree();

            return (leftSubTree != null) && (rightSubTree == null) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        public int countNodesWithBothSubTree() {
            int leftCount = leftSubTree == null ? 0 : leftSubTree.countNodesWithBothSubTree();
            int rightCount = rightSubTree == null ? 0 : rightSubTree.countNodesWithBothSubTree();

            return (leftSubTree != null) && (rightSubTree != null) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        public int getHeight() {
            int leftHeight = leftSubTree == null ? 0 : leftSubTree.getHeight();
            int rightHeight = rightSubTree == null ? 0 : rightSubTree.getHeight();

            return leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
        }

        public int countNodes() {
            int leftCount = leftSubTree == null ? 0 : leftSubTree.countNodes();
            int rightCount = rightSubTree == null ? 0 : rightSubTree.countNodes();

            return leftCount + rightCount + 1;
        }

        public int countNodesOnDepth(int depth, int recursiveDepth = 0) {
            if (depth < recursiveDepth) {
                return 0;
            }

            if (depth == recursiveDepth) {
                return 1;
            }

            int leftCount = leftSubTree == null ? 0 : leftSubTree.countNodesOnDepth(depth, recursiveDepth + 1);
            int rightCount = rightSubTree == null ? 0 : rightSubTree.countNodesOnDepth(depth, recursiveDepth + 1);
            return leftCount + rightCount;
        }

        public int pathLength(T val, int recursiveDepth = 0) {
            if (value.Equals(val)) {
                return recursiveDepth;
            }

            if (value.isLarger(val) && leftSubTree != null) {
                return leftSubTree.pathLength(val, recursiveDepth + 1);
            }

            if (!value.isLarger(val) && rightSubTree != null) {
                return rightSubTree.pathLength(val, recursiveDepth + 1);
            }

            return -1;
        }

        public T lookUpLargest() {
            if (rightSubTree == null) {
                return value;
            } else {
                return rightSubTree.lookUpLargest();
            }
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
            Console.WriteLine(value.ToString());

            if (leftSubTree != null) {
                leftSubTree.print(indent, rightSubTree == null);
            }
            if (rightSubTree != null) {
                rightSubTree.print(indent, true);
            }
        }

        public BinaryTree(T val) {
            value = val;
        }

        public BinaryTree(IEnumerable<T> vals) {
            value = vals.First();

            foreach (var i in vals) {
                insert(i);
            }
        }
    }
}
