using System;
namespace pooRPG.src.Entities{
    public class Maegi : Hero{
        public Maegi(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack){
        }
        public void fight(Hero warrior,Hero bandit,string Spell, int SPower){
            double damage = 0;
            if (this.hp>0){
                damage=SPower*(1+Spell.Length/3)*(1+this.level)/1000;
                if (warrior.hp >= bandit.hp){
                    Console.WriteLine( this.name + " casts "+ Spell+" at "+warrior.name+". Doing " + Math.Round(damage, 2) +" damage.");
                    warrior.hp -= damage;
                }
            else{ 
                Console.WriteLine( this.name + " casts "+ Spell+" at "+bandit.name+". Doing " + Math.Round(damage, 2) +" damage.");
                bandit.hp -= damage;}
            }
            else{Console.WriteLine(this.name + " is dead.");}
        }
    }

}