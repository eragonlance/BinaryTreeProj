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

        protected override void getAllNodesRec<T>(BinaryTree<T> tree, ref List<T> buffer) {
            buffer.Add(tree.Node);
            var tmpTree = tree.LeftSubTree;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }

            tmpTree = tree.RightSubTree;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }
        }

        private NLRVisitor() { }
    }
}
