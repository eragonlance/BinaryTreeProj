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

        protected override void getAllNodesRec<T>(BinaryTree<T> tree, ref List<T> buffer) {
            var tmpTree = tree.LeftSubTree;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }

            tmpTree = tree.RightSubTree;

            if (tmpTree != null) {
                getAllNodesRec(tmpTree, ref buffer);
            }

            buffer.Add(tree.Node);
        }

        private LRNVisitor() { }
    }
}
