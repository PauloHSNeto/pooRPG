using System;

namespace pooRPG.src.Entities
{
    public class Hero
    {
        public Hero (string Name, int Level ,string  Herotype, double HP, double Attack )
        {
            this.name = Name;
            this.level= Level;
            this.type = Herotype;
            this.hp = HP;
            this.attack = Attack;

        }
        
        public string name { get; set; }
        public int level { get; set; }

        public string type { get; set; }

        public double  hp { get; set; }

        public double  attack { get; set; }


        public void greeting()
        
        {
            Console.WriteLine("The Hero "+ this.name+" is a level " + this.level+ " " +this.type+ ", thier hp and attack are:  "+this.hp + "  " + this.attack);
        }

    }
}