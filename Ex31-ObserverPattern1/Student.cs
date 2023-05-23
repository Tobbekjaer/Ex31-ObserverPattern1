using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_ObserverPattern1
{
    public class Student : Observer
    {
        private Academy subject;
        public string Message { get; set; }

        // Name can only be set when creating a new instance of the class
        private string _name;

        public string Name
        {
            get { return _name; }
            private set
            {
                _name = value;
            }
        }

        public Student(Academy subject, string name)
        {
            this.subject = subject;
            Name = name;
        }

        public override void Update()
        {
            Console.WriteLine($"Studerende {Name} modtog nyheden '{subject.Message}' fra akademiet {subject.Name}");
        }
    }
}

