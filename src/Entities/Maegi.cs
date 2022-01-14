using System;
namespace pooRPG.src.Entities
{
    public class Maegi : Hero
    {
        public Maegi(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }
        public void fight(Hero hero,string Spell, int SPower)
        {
            double damage = SPower*(1+Spell.Length/3)*(1+this.level)/1000;      
            Console.WriteLine( this.name + " casts "+ Spell+" at "+hero.name+". Doing " + damage +" damage.");
            hero.hp -= damage;
        }
    }

}