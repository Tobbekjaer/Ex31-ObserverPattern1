using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_ObserverPattern1
{
    public class Academy : Subject
    {
        // Name can only be set when creating a new instance of the class
        private string _name;

        public string Name
        {
            get { return _name; }
            private set {
                _name = value;
                Notify();
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set {
                _message = value;
                Notify();
            }
        }

        public Academy(string name)
        {
            Name = name;    
        }


    }
}
