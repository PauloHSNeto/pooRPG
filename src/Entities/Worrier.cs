using System;

namespace pooRPG.src.Entities
{
    public class Worrier : Hero
    {
        public Worrier(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }
            public void fight(Hero mage, Hero bandit,string Weapon, int Hits)
        {
            double damage = 0;
            if (this.hp > 0){damage = Hits*(this.attack+this.hp/100)*(1+this.level/10)/10;
               if (mage.hp >= bandit.hp){
            Console.WriteLine( this.name + " attacks "+ mage.name +" with their "+ Weapon+ " "+ Hits+" times. Doing "+ Math.Round(damage, 2)+ " damage.");
                            mage.hp -= damage;
            }
            else {
            Console.WriteLine( this.name + " attacks "+ bandit.name +" with their "+ Weapon+ " "+ Hits+" times. Doing "+ Math.Round(damage, 2)+ " damage.");
                            bandit.hp -= damage;}}

            else{Console.WriteLine(this.name + " is dead.");}     
                


        }
    
    }

}