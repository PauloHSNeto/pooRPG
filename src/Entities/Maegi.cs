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

            Console.WriteLine( this.name + " casts "+ Spell);

        }
    }

}