using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4
{
    class Cat
    {
        //States
        //fields
        private string name;

        //properties -- in order to interact with fields, must go through properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //Behaviors

        //Constructors
        public Cat()
        {
            //default constructor - has no parameters in the parentheses
        }
    }
}
