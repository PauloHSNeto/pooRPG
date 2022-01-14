using System;
using pooRPG.src.Entities;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello RPG WOrld!");
Hero link = new Hero("Lonk", 29, "Worrier",150.0, 15.0);
Console.WriteLine("Our Hero "+ link.name+" is a level " + link.level+ " " +link.type+ ", thier hp and attack are:  "+link.hp + "  " + link.attack);
Hero lank = new Hero("Lank", 25, "Maegi",80.0, 35.0);
Console.WriteLine("Our new Hero "+ lank.name+" is a level " + lank.level+ " " +lank.type+ ", thier hp and attack are:  "+lank.hp + "  " + lank.attack);
