using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree.NodeTypes {
    class StringNode : NodeType<StringNode> {
        protected String data;

        public bool Equals(StringNode node) {
            return this.data.Equals(node.data);
        }

        public bool isLarger(StringNode node) {
            return String.Compare(data, node.data) > 0;
        }

        public override string ToString() {
            return data;
        }

        public StringNode(String data) {
            this.data = data;
        }
    }
}
