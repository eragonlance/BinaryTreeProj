using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProj {
    abstract class Subject<T> where T : Subject<T> {
        protected List<Observer<T>> observers = new List<Observer<T>>();

        ///<summary>attach an observer</summary>
        public void attach(Observer<T> o) {
            observers.Add(o);
        }

        ///<summary>detach an observer</summary>
        public void detach(Observer<T> o) {
            observers.Remove(o);
        }

        ///<summary>notify all observers to update</summary>
        public void notify() {
            foreach (var i in observers) {
                i.update((T)this);
            }
        }
    }
}
