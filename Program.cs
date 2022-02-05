using System;
using pooRPG.src.Entities;
using pooRPG.src.Entities.HeroTypes;
Random rnd = new Random();



//nomes de heroes spells e weapons
var names = new List<string>{"Aldwin","Aldwyn","Anakin","Atreyu","Artemis","Bastian","Ben","Bronn","Cullen","Daario","Draco","Eddard",
"Emmett","Eowyn","Falkor","Faramir","Finn","Gandalf","Gendry","Gregor","Han","Jaime","Jaqen","Jorah","Kylo","Legolas","Loras","Luke","Oberyn",
"Obi","Petyr","Pippin","Poe","Ramsay","Ren","Rool","Roose","Samwise","Sandor","Sirius","Shasta","Stannis","Sulu","Theon","Tirian","Tormund",
"Tyrion","Tumun","Willow","Bode","Amidala","Aravis","Arwen","Arya","Astoria","Bellatrix","Brienne","Catelyn","Cersei","Cherlindrea","Daenerys",
"Elora","Fleur","Galadriel","Gen","Gilly","Hermione","Jadis","Katniss","Lavender","Leia","Luna","Margaery","Melisandre","Merry","Minerva",
"Missandei","Morla","Nymphadora","Nyota","Olenna","Ornela","Osha","Padme","Pansy","Raziel","Rey","Ripley","Sansa","Shae","Sorsha","Sybil",
"Willow","Ygritte","Kinsey"};
var spells = new List<string>{"Eldritch Blast","Fire Bolt","Frostbite","Ray of Frost","Sacred Flame","Shocking Grasp","Thunderclap",
"Word of Radiance","Booming Blade ","Green-Flame Blade","Lightning Lure","Burning Hands","Chaos Bolt","Chromatic Orb","Cure Wounds","Divine Favor","Earth Tremor",
"Faerie Fire","Guiding Bolt","Hellish Rebuke","Magic Missile","Searing Smite","Thunderous Smite","Thunderwave","Witch Bolt","Wrathful Smite",
"Aganazzar's Scorcher","Branding Smite","Continual Flame","Darkness","Flame Blade","Gust of Wind","Melf","Acid Arrow","Moonbeam","Scorching Ray",
"Shatter","Snilloc","Snowball Swarm","Spiritual Weapon","Blinding Smite","Fireball","Lightning Bolt",
"Melf's Minute Meteors","Ice Storm",
"Sickening Radiance","Staggering Smite","Storm Sphere","Vitriolic Sphere","Wall of Fire","Cone of Cold","Destructive Wave","Flame Strike",
"Hallow","Holy Weapon","Immolation","Maelstrom","Wall of Force","Wrath of Nature",
"Chain Lightning","Otiluke's Freezing Sphere","Sunbeam","Crown of Stars","Delayed Blast Fireball",
"Divine Word","Fire Storm","Mordenkainen's Sword","Prismatic Spray","Whirlwind","Earthquake","Maddening Darkness","Sunburst","Meteor Swarm"};
var weapons = new List<string>{"Club","Dagger","Greatclub","Handaxe","Javelin","Light hammer","Mace","Quarterstaff","Sickle","Spear","Unarmed strike","Battleaxe",
"Flail","Glaive","Greataxe","Greatsword ","Halberd","Lance","Longsword","Maul","Morningstar","Pike","Rapier","Scimitar","Shortsword","Trident","War pick",
"Warhammer","Whip",};
var rangedWeapons = new List<string>{"Blowgun","Crossbow","Crossbow","Longbow","ShortBow", "Hunting Bow"};

//initial conditions
int warrior_wins = 0;
int mage_wins = 0;
int bandit_wins = 0;
List<string> winnertypes = new List<string>();
int tourney = 0;
while (tourney <50){
Console.WriteLine("Hello RPG BattleRoyalle World!");
Worrier warrior = new Worrier(names[rnd.Next(names.Count)], rnd.Next(25,35), "Worrier", rnd.Next(120,170), 15);
Maegi mage = new Maegi(names[rnd.Next(names.Count)], rnd.Next(25,35), "Maegi",rnd.Next(80,100), 1);
Bandeet bandit = new Bandeet(names[rnd.Next(names.Count)], rnd.Next(25,35), "Bandeet", rnd.Next(70,130), 3);
Heelah healer = new Heelah(names[rnd.Next(names.Count)],rnd.Next(25,35),"Heelah", rnd.Next(35,60),13);

int turn =1;
string warWeapon = weapons[rnd.Next(weapons.Count)];
warrior.greeting();
mage.greeting();
bandit.greeting();

healer.heelahgreeting();
//main game
do {
Console.WriteLine();

Console.WriteLine("Turn "+ turn);
Console.WriteLine();


Console.WriteLine();
healer.heals(warrior,mage,bandit);
Console.WriteLine();

warrior.fight(mage,bandit,warWeapon,rnd.Next(3,6));
mage.fight(bandit,warrior,spells[rnd.Next(spells.Count)],rnd.Next(50,200));
bandit.fight(warrior,mage, rnd.Next(5,25),rangedWeapons[rnd.Next(rangedWeapons.Count)]);

Console.WriteLine();

warrior.displayHp();
mage.displayHp();
bandit.displayHp();
Console.WriteLine();


turn++;
}while ((warrior.hp>0 && mage.hp>0)||(warrior.hp>0 && bandit.hp>0)||(bandit.hp>0 && mage.hp>0));
Console.WriteLine();
Console.WriteLine();
if (warrior.hp != 0) {Console.WriteLine("The duel is over! "+ warrior.name+ " the "+ warrior.type+" has won with "+Math.Round(warrior.hp, 2)+ " HitPoints left!!! ");winnertypes.Add(warrior.type); warrior_wins++ ;}
if (mage.hp != 0) {Console.WriteLine("The duel is over! "+ mage.name+ " the "+ mage.type+" has won with "+Math.Round(mage.hp, 2)+ " HitPoints left!!! ");winnertypes.Add(mage.type);mage_wins++;}
if (bandit.hp != 0) {Console.WriteLine("The duel is over! "+ bandit.name+" the "+ bandit.type+" has won with "+ Math.Round(bandit.hp, 2)+ " HitPoints left!!! ");winnertypes.Add(bandit.type);bandit_wins++;}

tourney++;
}

if (tourney>2){
Console.WriteLine("______________________________________________________________________________________");
Console.WriteLine();

Console.WriteLine("Warrior wins: "+warrior_wins );
Console.WriteLine("Mage wins: " +mage_wins);
Console.WriteLine("Bandit wins: "+ bandit_wins);
}