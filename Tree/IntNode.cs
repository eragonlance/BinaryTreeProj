using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree.INodeType {
    class IntNode : INodeType<IntNode> {
        private int data;

        public bool Equals(IntNode value) {
            return data == value.data;
        }

        public bool isLarger(IntNode value) {
            return data > value.data;
        }

        public override string ToString() {
            return data.ToString();
        }

        public IntNode(int value) {
            this.data = value;
        }

        ///<summary>convert a range of integers to IntNode</summary>
        public static IEnumerable<IntNode> convert(IEnumerable<int> data) {
            foreach (var i in data) {
                yield return new IntNode(i);
            }
        }
    }
}
