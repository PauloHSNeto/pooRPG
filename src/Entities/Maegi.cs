using System;

namespace pooRPG.src.Entities
{
    public class Maegi : Hero
    {
        public Maegi(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }


        public void fight(string Spell)
        {
            double damage = ((this.hp+this.level)*(1+Spell.Length/10))/2;      
            Console.WriteLine( this.name + " casts "+ Spell+". Doing " + damage +" damage."  );

        }
    }

}