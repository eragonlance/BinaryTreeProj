using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree {
    class BinaryTree {
        protected int value = 0;
        protected BinaryTree leftSubTree = null;
        protected BinaryTree rightSubTree = null;

        public int Value {
            get { return value; }
            set { this.value = value; }
        }

        public BinaryTree LeftSubTree {
            get { return leftSubTree; }
            set { leftSubTree = value; }
        }

        public BinaryTree RightSubTree {
            get { return rightSubTree; }
            set { rightSubTree = value; }
        }

        public void insert(int val) {
            if (val == value) {
                return;
            }

            if (val < value) {
                if (leftSubTree == null) {
                    leftSubTree = new BinaryTree(val);
                } else {
                    leftSubTree.insert(val);
                }
            } else {
                if (rightSubTree == null) {
                    rightSubTree = new BinaryTree(val);
                } else {
                    rightSubTree.insert(val);
                }
            }
        }

        public int lookUpLargest() {
            if (rightSubTree == null) {
                return this.value;
            } else {
                return this.rightSubTree.lookUpLargest();
            }
        }

        public int getHeight() {
            int leftHeight = leftSubTree == null ? 0 : leftSubTree.getHeight();
            int rightHeight = rightSubTree == null ? 0 : rightSubTree.getHeight();

            if ((leftHeight + rightHeight) == 0)
                return 1;
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
            Console.WriteLine(value);

            if (leftSubTree != null) {
                leftSubTree.print(indent, rightSubTree == null);
            }
            if (rightSubTree != null) {
                rightSubTree.print(indent, true);
            }
        }

        public BinaryTree(int val) {
            this.value = val;
        }
    }
}
