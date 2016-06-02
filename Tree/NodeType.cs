using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree.NodeType {
    interface NodeType<T> : IEquatable<T> where T : NodeType<T> {
        bool isLarger(T node);
        String ToString();
    }
}
