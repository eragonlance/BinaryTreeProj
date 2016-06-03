using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree {
    abstract class BinTreeVisitor {
        ///<summary>visit a binary tree and return all nodes</summary>
        public IEnumerable<T> visit<T>(BinaryTree<T> tree) where T : INodeType<T> {
            List<T> buffer = new List<T>();
            getAllNodesRec(tree, ref buffer);
            return buffer;
        }

        abstract protected void getAllNodesRec<T>(BinaryTree<T> tree, ref List<T> buffer) where T : INodeType<T>;
    }
}