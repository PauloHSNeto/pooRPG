using System;

namespace pooRPG.src.Entities
{
    public class Worrier : Hero
    {
        public Worrier(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }
    
      public void greeting()
        
        {
            Console.WriteLine("Our Hero "+ this.name+" is a level " + this.level+ " " +this.type+ ", thier hp and attack are:  "+this.hp + "  " + this.attack);
        }
    
    
    }

}