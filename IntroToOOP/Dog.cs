using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        private string hairLength;
        private int height;
        private int runningSpeed;
        private int weight;


        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Dog()
        {

        }
        public Dog( string hairlength, int height, int runningSpeed, int weight)
        {
            this.hairLength = hairlength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Run()
        {
            Console.WriteLine("The dog is running " + runningSpeed + " mph!");
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            weight -= 1;
            Console.WriteLine("You lost a pound! Your new weight is" + weight);
        }

        public void Cuddle()
        {
            Console.WriteLine("I love you Puppers");
        }

    }

}
