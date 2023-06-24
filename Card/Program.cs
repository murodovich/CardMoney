// See https://aka.ms/new-console-template for more information
using Card;

Console.WriteLine("Hello, World!");

Uzcard uzcard = new Uzcard("2520","Sarvar",120500);

uzcard.AddWithBonus(20000);
uzcard.Money = 100;
uzcard.Add(50000);
Humo humo = new Humo("2520","Sarvar",100000);
humo.Add(20000);

Console.WriteLine(humo.Money);
Console.WriteLine(uzcard.Money);