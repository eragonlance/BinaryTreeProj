using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree {
    class LRNVisitor : BinTreeVisitor {
        private static LRNVisitor instance = new LRNVisitor();

        ///<summary>get Left-Right-Node visitor</summary>
        public static LRNVisitor get() {
            return instance;
        }

        protected override void getAllNodesRec<T>(BinaryNode<T> tree, ref List<T> buffer) {
            var tmpTree = tree.LeftNode;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }

            tmpTree = tree.RightNode;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }

            buffer.Add(tree.Value);
        }

        private LRNVisitor() { }
    }
}
