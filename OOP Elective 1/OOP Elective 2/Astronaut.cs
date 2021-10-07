using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Elective_2
{
    class Astronaut
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public Astronaut(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
