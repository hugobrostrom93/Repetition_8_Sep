// ReSharper disable All
// See https://aka.ms/new-console-template for more information

/* 
Console.WriteLine("Hej vad heter du?");
string namn = "Hugo";
Console.WriteLine("Jag heter " + namn);


string namn;
Console.Write("Hej vad heter du? ");
namn = Console.ReadLine();
Console.WriteLine($"Hej {namn}");

*/

// Deklarera och tilldela värdet 0  

int age = 0;

// Input
Console.Write("Ange din ålder: ");
string input = Console.ReadLine();

// Bearbetning
age = int.Parse(input);
// Eller age = Convert.ToInt32(input);
double days = 365.25 * age;

// Presentation av resultat 
Console.WriteLine($"Du har levt {days} dagar i ditt liv. WOW!");

// Övning Tapetremsor 

