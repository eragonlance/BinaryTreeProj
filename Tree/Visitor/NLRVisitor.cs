using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree {
    class NLRVisitor : BinTreeVisitor {
        private static NLRVisitor instance = new NLRVisitor();

        ///<summary>get Node-Left-Right visitor</summary>
        public static NLRVisitor get() {
            return instance;
        }

        protected override void getAllNodesRec<T>(BinaryNode<T> tree, ref List<T> buffer) {
            buffer.Add(tree.Value);
            var tmpTree = tree.LeftNode;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }

            tmpTree = tree.RightNode;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }
        }

        private NLRVisitor() { }
    }
}
