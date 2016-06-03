using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree {
    class LNRVisitor : BinTreeVisitor {
        private static LNRVisitor instance = new LNRVisitor();

        ///<summary>get Left-Node-Right visitor mode</summary>
        public static LNRVisitor get() {
            return instance;
        }

        protected override void getAllNodesRec<T>(BinaryTree<T> tree, ref List<T> buffer) {
            var tmpTree = tree.LeftSubTree;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }

            buffer.Add(tree.Node);

            tmpTree = tree.RightSubTree;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }
        }

        private LNRVisitor() { }
    }
}
