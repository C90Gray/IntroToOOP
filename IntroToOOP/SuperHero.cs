using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class SuperHero
    {
        private string superPower;
        private int strength;
        private bool hasCape = true;
        private bool isInvincable;

        public string SuperPower
        {
            get { return this.superPower; }
            set { this.superPower = value; }
        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }

        public bool IsInvincable
        {
            get { return this.isInvincable; }
            set { this.isInvincable = value; }
        }

        public SuperHero()
        {

        }

        public SuperHero(string superPower, int strength, bool hasCape, bool isInvincable)
        {
            this.superPower = superPower;
            this.strength = strength;
            this.hasCape = hasCape;
            this.isInvincable = isInvincable;
        }

        public SuperHero(string superPower, int strength)
        {
            this.superPower = superPower;
            this.strength = strength;
        }

        public void Turbo()
        {
            if (isInvincable == false)
            {
                isInvincable = true;
            }
        }

        public void BattleCry()
        {
            Console.WriteLine("\a\a\a\a");
        }

        public void Eats()
        {
            strength += 3;
        }

        public void DirectHit()
        {
            strength -= 5;
        }
    }

}
