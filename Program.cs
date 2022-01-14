using System;
using pooRPG.src.Entities;
Random rnd = new Random();




Console.WriteLine("Hello RPG World!");
Worrier link = new Worrier("Link", rnd.Next(25,35), "Worrier", rnd.Next(1200,1700), 10);
Maegi lank = new Maegi("Lank", rnd.Next(25,35), "Maegi",rnd.Next(800,1000), 1);
Bandeet lonk = new Bandeet("Lonk", rnd.Next(25,35), "Bandeet", rnd.Next(900,1100), 3);
Heelah zolda = new Heelah("Zolda",rnd.Next(25,35),"Heelah", rnd.Next(500,900),10);

int turn =1;

link.greeting();
lank.greeting();
lonk.greeting();
do {
Console.WriteLine();

link.fight(lank,"Sword",rnd.Next(3,6));
lank.fight(lonk,"Divine Ice and Fire Beam",rnd.Next(0,200));
lonk.fight(link, rnd.Next(15,25));

Console.WriteLine();
zolda.heals(link,lank,lonk);
Console.WriteLine();

link.displayHp();
lank.displayHp();
lonk.displayHp();


turn++;
Console.WriteLine();
Console.WriteLine("Turn "+ turn);
Console.WriteLine();

}while ((link.hp>0 && lank.hp>0 && lonk.hp>0));

Console.WriteLine("The duel is over: ");

link.survival();

lank.survival();

lonk.survival();


