using System;

namespace pooRPG.src.Entities
{
    public class Bandeet : Hero
    {
        public Bandeet(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }
        public void fight(int Shots)
        {

            Console.WriteLine( this.name + " shoots "+ Shots + " times.");

        }
    }

}