using System;
using pooRPG.src.Entities;
Random rnd = new Random();




Console.WriteLine("Hello RPG World!");
Worrier link = new Worrier("Link", rnd.Next(25,35), "Worrier", rnd.Next(120,170), 10.0);
Maegi lank = new Maegi("Lank", rnd.Next(25,35), "Maegi",rnd.Next(80,100), 1.0);
Bandeet lonk = new Bandeet("Lonk", rnd.Next(25,35), "Bandeet", rnd.Next(90,110), 3.0);

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

