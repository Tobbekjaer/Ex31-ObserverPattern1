﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_ObserverPattern1
{
    // The "Subject" abstract class
    public abstract class Subject
    {
        // Private list of observers
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer o) 
        { 
            observers.Add(o);
        }
        public void Detach(Observer o) 
        {
            observers.Remove(o);
        }

        public void Notify() 
        {
            foreach (Observer o in observers) {
                o.Update();
            }
        }

    }
}
