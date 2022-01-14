using System;

namespace pooRPG.src.Entities
{
    public class Worrier : Hero
    {
        public Worrier(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }
            public void fight(Hero hero,string Weapon, int Hits)
        {
            double damage = Hits*(this.attack+this.hp/100)*(1+this.level/10)/10;    
            Console.WriteLine( this.name + " attacks "+ hero.name +" with their "+ Weapon+ " "+ Hits+" times. Doing "+ damage+ " damage.");
            hero.hp -= damage;
        }
    
    }

}