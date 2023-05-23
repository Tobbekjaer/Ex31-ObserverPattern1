using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_ObserverPattern1
{
    // The "ConcreteObserver" class
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;

        // Gets or sets subject state 
        public int State { get; set; } = 0;

        public ConcreteObserver(ConcreteSubject subject) 
        {
            this.subject = subject;
            State = subject.State;
        }

        public override void Update() 
        {
            State = subject.State;
        }

    }
}
