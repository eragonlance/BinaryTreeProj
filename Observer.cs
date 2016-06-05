using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj {
    interface Observer<T> where T : Subject<T> {
        ///<summary>interface method for updating observer</summary>
        void update(T s);
    }
}
