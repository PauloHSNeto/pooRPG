using System;

namespace pooRPG.src.Entities
{
    public class Heelah : Hero
    {
    public Heelah(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }
    public void heals(Hero worrier,Hero maegi,Hero bandeet )
    {
        string weakest ="noone"; 
        if (worrier.hp>0 && worrier.hp < maegi.hp && worrier.hp <bandeet.hp){weakest = worrier.name; worrier.hp+=this.attack; }
        else if (maegi.hp>0 && maegi.hp < worrier.hp && maegi.hp <bandeet.hp){weakest = maegi.name; maegi.hp+=this.attack;}
        else if(bandeet.hp>0) {weakest=bandeet.name; bandeet.hp+=this.attack;}
        Console.WriteLine(this.name+" casts heal on "+ weakest );
    }

      public void greeting()
        
        {
            Console.WriteLine("\nThe Healer "+ this.name+ " is at level " + this.level+ ", and will help out the weakest hero on each turn, as long as they are all alive." );
        }

    }


}