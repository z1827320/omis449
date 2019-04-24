using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{
     abstract class Students
    {
        //fields
        private string _name;
        private string _id;

        //constructor
        public Students(string name, string id)
        {
            _name = name;
            _id = id;
        }

        //name property
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        //id property
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        //required hours property (abstract)
        public abstract double RequiredHours
        {
            get;
        }
    }
}
