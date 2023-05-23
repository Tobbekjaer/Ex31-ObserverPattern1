using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_ObserverPattern1
{
    // The "ConreteSubject" class
    public class ConcreteSubject : Subject
    {
        // Gets or sets subject state
        private int _state = 0;

        public int State
        {
            get { return _state; }
            set {
                _state = value;
                // Notify the Subjects about a change in it's state
                Notify();
            }
        }


    }
}
