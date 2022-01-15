using System;

namespace pooRPG.src.Entities
{
    public class Bandeet : Hero
    {
        public Bandeet(string Name, int Level, string Herotype, double HP, double Attack) : base(Name, Level, Herotype, HP, Attack)
        {
        }
        public void fight(Hero warrior, Hero mage ,int Shots, string rangedWeapon)
        {
            double damage = this.attack*Shots*(1+this.level/10)/8;
                       
            if (warrior.hp >= mage.hp){
                            Console.WriteLine( this.name + " shoots at "  + warrior.name +" with their "+ rangedWeapon +" "+ Shots + " times. Doing "+ Math.Round(damage, 2) + " damage.");
                            warrior.hp -= damage;
            }
            else {
                            Console.WriteLine( this.name + " shoots at "  + mage.name +" "+ Shots + " times. Doing "+ Math.Round(damage, 2) + " damage.");
                            mage.hp -= damage;}

        }
        
        public string attackWeakest( Hero warrior, Hero mage){

            if (warrior.hp <= mage.hp){return warrior.name;}
            else {return mage.name;}

        }
    }

}