using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj.Tree.INodeType {
    interface INodeType<T> : IEquatable<T> where T : INodeType<T> {
        bool isLarger(T value);
        String ToString();
    }
}
