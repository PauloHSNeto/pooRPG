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
        if (worrier.hp < maegi.hp && worrier.hp <bandeet.hp){Console.WriteLine(this.name+ " heals "+ worrier.name); worrier.hp+=20; }
        else if (maegi.hp < worrier.hp && maegi.hp <bandeet.hp){Console.WriteLine(this.name+ " heals "+ maegi.name);maegi.hp+=20;}
        else{Console.WriteLine(this.name+ " heals "+ bandeet.name);bandeet.hp+=20;}

    }



    }


}