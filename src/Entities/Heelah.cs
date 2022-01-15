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
        int totalHealed = 0;
        string weakest =""; 
        if (worrier.hp < maegi.hp && worrier.hp <bandeet.hp){weakest = worrier.name; worrier.hp+=this.attack; }
        else if (maegi.hp < worrier.hp && maegi.hp <bandeet.hp){weakest = maegi.name; maegi.hp+=this.attack;}
        else{weakest=bandeet.name; bandeet.hp+=this.attack;}
        totalHealed+=20;
        Console.WriteLine(this.name+" casts heal on "+ weakest );
    }

      public void greeting()
        
        {
            Console.WriteLine("\nThe Healer "+ this.name+ " is at level " + this.level+ ", and will help out the weakest hero on each turn" );
        }

    }


}