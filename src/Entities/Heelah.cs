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
        if (worrier.hp < maegi.hp && worrier.hp <bandeet.hp){weakest = worrier.name; worrier.hp+=20; }
        else if (maegi.hp < worrier.hp && maegi.hp <bandeet.hp){weakest = maegi.name; maegi.hp+=20;}
        else{weakest=bandeet.name; bandeet.hp+=20;}
        totalHealed+=20;
        Console.WriteLine(this.name+" casts heal on "+ weakest );
    }



    }


}