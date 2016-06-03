using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree.INodeType {
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

        public static IEnumerable<IntNode> convert(IEnumerable<int> data) {
            foreach (var i in data) {
                yield return new IntNode(i);
            }
        }
    }
}
