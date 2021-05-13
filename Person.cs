using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public struct Person
    {
        private string personName;
        public Person(string name ) 
        {
            this.personName = name;
        }

        public override string ToString()
        {
            return this.personName;
        }
    }
}
