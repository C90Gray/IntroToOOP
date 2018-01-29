using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //I need STATES


        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
       


        //I need BEHAVIORS

        //Constructors
        public Cat()
        {
            //default constructor
            //takes no parameters
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        //methods
        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
            }

            Console.WriteLine("is the cat hungry? " + isHungry);
        }
    }
}
