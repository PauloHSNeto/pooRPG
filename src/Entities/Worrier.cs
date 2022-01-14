using System;

namespace pooRPG.src.Entities
{
    public class Worrier : Hero
    {
        public Worrier(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }
        
            public void fight(string Weapon, int Hits)
        {

            Console.WriteLine( this.name + " attack with their "+ Weapon+ " "+ Hits+" times.");

        }
    
    }

}