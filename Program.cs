using System;
using pooRPG.src.Entities;

Console.WriteLine("Hello RPG World!");
Worrier link = new Worrier("Link", 29, "Worrier",150.0, 10.0);
Maegi lank = new Maegi("Lank", 25, "Maegi",80.0, 1.0);
Bandeet lonk = new Bandeet("Lonk", 31, "Bandeet", 100.0, 3.0);

link.greeting();
lank.greeting();
lonk.greeting();
do {
Console.WriteLine();

link.fight(lank,"Sword",2);
lank.fight(lonk,"Greater Ice Beam");
lonk.fight(link, 9);

Console.WriteLine();

link.displayHp();
lank.displayHp();
lonk.displayHp();

Console.WriteLine();
}while ((link.hp>0 && lank.hp>0 && lonk.hp>0));

string loser="";
if (link.hp<=0){loser=link.name;}
if (lank.hp<=0){loser=lank.name;}
if (lonk.hp<=0){loser=lonk.name;}

Console.WriteLine("The duel is over, "+ loser +" is dead." );

