using System;

namespace pooRPG.src.Entities
{
    public class Bandeet : Hero
    {
        public Bandeet(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }
        public void fight(Hero hero,int Shots)
        {
            double damage = this.attack*Shots;
            Console.WriteLine( this.name + " shoots at "  + hero.name +" "+ Shots + " times. Doing "+ damage + " damage.");
            hero.hp -= damage;

        }
    }

}