using BinaryTreeProj.Tree.NodeType;
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

        public BinaryTree<T> LeftSubTree {
            get { return leftSubTree; }
            set { leftSubTree = value; }
        }

        public BinaryTree<T> RightSubTree {
            get { return rightSubTree; }
            set { rightSubTree = value; }
        }

        public void insert(T val) {
            if (value.Equals(val)) {
                return;
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
        }

        public T lookUpLargest() {
            if (rightSubTree == null) {
                return value;
            } else {
                return rightSubTree.lookUpLargest();
            }
        }

        public int getHeight() {
            int leftHeight = leftSubTree == null ? 0 : leftSubTree.getHeight();
            int rightHeight = rightSubTree == null ? 0 : rightSubTree.getHeight();

            return leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
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
            this.value = val;
        }
    }
}
