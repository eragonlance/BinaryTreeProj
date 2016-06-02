using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree.NodeType {
    class IntNode : NodeType<IntNode> {
        private int data;

        public bool Equals(IntNode node) {
            return data == node.data;
        }

        public bool isLarger(IntNode node) {
            return data > node.data;
        }

        public override string ToString() {
            return data.ToString();
        }

        public IntNode(int data) {
            this.data = data;
        }
    }
}
