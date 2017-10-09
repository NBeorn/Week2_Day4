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
        //fields - usually private, the value can be set here
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //properties -- in order to interact with fields, must go through properties
        public string Name
        {
            get { return this.name; } //returns the value in the field within the program
            set { this.name = value; } //sets field equal to value provided within program
        }

        //Behaviors

        //Constructors
        public Cat()
        {
            //default constructor - has no parameters in the parentheses
        }

        public Cat(string name, int age, string furColor) //overloaded constructor
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        //Methods

        public void Eat()
        {
            if(isHungry == true)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void WorkOut()
        {
            if(isHungry == false)
            {
                isHungry = true;
            }
            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);
        }
    }
}
