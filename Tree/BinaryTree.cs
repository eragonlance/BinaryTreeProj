using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree {
    class BinaryTree<T> where T : INodeType<T> {
        private T node = default(T);
        private BinaryTree<T> leftSubTree = null;
        private BinaryTree<T> rightSubTree = null;

        public T Node {
            get {
                return node;
            }

            set {
                node = value;
            }
        }

        public BinaryTree<T> LeftSubTree {
            get {
                return leftSubTree;
            }

            set {
                leftSubTree = value;
            }
        }

        public BinaryTree<T> RightSubTree {
            get {
                return rightSubTree;
            }

            set {
                rightSubTree = value;
            }
        }

        ///<summary>get all values of this tree in String, visit L-N-R by default</summary>
        public IEnumerable<String> getAllValues(BinTreeVisitor visitor = null) {
            if (visitor == null) {
                visitor = LNRVisitor.get();
            }

            return visitor.visit(this).Select(x => x.ToString());
        }

        public bool insert(T n) {
            if (Node.Equals(n)) {
                return false;
            }

            if (Node.isLarger(n)) {
                if (LeftSubTree == null) {
                    LeftSubTree = new BinaryTree<T>(n);
                } else {
                    LeftSubTree.insert(n);
                }
            } else {
                if (RightSubTree == null) {
                    RightSubTree = new BinaryTree<T>(n);
                } else {
                    RightSubTree.insert(n);
                }
            }

            return true;
        }

        ///<summary>count leaf nodes</summary>
        public int countLeafNodes() {
            int leftCount = LeftSubTree == null ? 0 : LeftSubTree.countLeafNodes();
            int rightCount = RightSubTree == null ? 0 : RightSubTree.countLeafNodes();

            return (leftCount + rightCount) == 0 ? 1 : leftCount + rightCount;
        }

        ///<summary>count nodes with only a single subtree</summary>
        public int nSingleOnly() {
            int leftCount = LeftSubTree == null ? 0 : LeftSubTree.nSingleOnly();
            int rightCount = RightSubTree == null ? 0 : RightSubTree.nSingleOnly();

            return ((LeftSubTree == null) ^ (RightSubTree == null)) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        ///<summary>count nodes with only right subtree</summary>
        public int nRightOnly() {
            int leftCount = LeftSubTree == null ? 0 : LeftSubTree.nRightOnly();
            int rightCount = RightSubTree == null ? 0 : RightSubTree.nRightOnly();

            return (LeftSubTree == null) && (RightSubTree != null) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        ///<summary>count nodes with only left subtree</summary>
        public int nLeftOnly() {
            int leftCount = LeftSubTree == null ? 0 : LeftSubTree.nLeftOnly();
            int rightCount = RightSubTree == null ? 0 : RightSubTree.nLeftOnly();

            return (LeftSubTree != null) && (RightSubTree == null) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        ///<summary>count nodes with both subtrees</summary>
        public int nBoth() {
            int leftCount = LeftSubTree == null ? 0 : LeftSubTree.nBoth();
            int rightCount = RightSubTree == null ? 0 : RightSubTree.nBoth();

            return (LeftSubTree != null) && (RightSubTree != null) ? leftCount + rightCount + 1 : leftCount + rightCount;
        }

        ///<summary>return total height of the tree</summary>
        public int getHeight() {
            int leftHeight = LeftSubTree == null ? 0 : LeftSubTree.getHeight();
            int rightHeight = RightSubTree == null ? 0 : RightSubTree.getHeight();

            return leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
        }

        ///<summary>count all nodes in the tree</summary>
        public int countNodes() {
            int leftCount = LeftSubTree == null ? 0 : LeftSubTree.countNodes();
            int rightCount = RightSubTree == null ? 0 : RightSubTree.countNodes();

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

            int leftCount = LeftSubTree == null ? 0 : LeftSubTree.countNodesOnDepth(depth, recursiveDepth + 1);
            int rightCount = RightSubTree == null ? 0 : RightSubTree.countNodesOnDepth(depth, recursiveDepth + 1);
            return leftCount + rightCount;
        }

        ///<summary>length of the path from root node to "n" node</summary>
        public int pathLength(T n, int recursiveDepth = 0) {
            if (Node.Equals(n)) {
                return recursiveDepth;
            }

            if (Node.isLarger(n) && LeftSubTree != null) {
                return LeftSubTree.pathLength(n, recursiveDepth + 1);
            }

            if (!Node.isLarger(n) && RightSubTree != null) {
                return RightSubTree.pathLength(n, recursiveDepth + 1);
            }

            return -1;
        }

        public T lookUpLargest() {
            if (RightSubTree == null) {
                return Node;
            } else {
                return RightSubTree.lookUpLargest();
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
            Console.WriteLine(Node.ToString());

            if (LeftSubTree != null) {
                LeftSubTree.print(indent, RightSubTree == null);
            }
            if (RightSubTree != null) {
                RightSubTree.print(indent, true);
            }
        }

        public BinaryTree(T n) {
            Node = n;
        }

        public BinaryTree(IEnumerable<T> nodes) {
            Node = nodes.First();

            foreach (var i in nodes) {
                insert(i);
            }
        }
    }
}
