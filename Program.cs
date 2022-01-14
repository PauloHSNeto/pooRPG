using System;
using pooRPG.src.Entities;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello RPG World!");
Worrier link = new Worrier("Link", 29, "Worrier",150.0, 10.0);
Maegi lank = new Maegi("Lank", 25, "Maegi",80.0, 1.0);
Bandeet lonk = new Bandeet("Lonk", 31, "Bandeet", 120.0, 3.0);

link.greeting();
lank.greeting();
lonk.greeting();

Console.WriteLine();

link.fight(lank,"Sword",2);
lank.fight(lonk,"Fire Ball");
lonk.fight(link, 9);

Console.WriteLine();

link.displayHp();
lank.displayHp();
lonk.displayHp();

