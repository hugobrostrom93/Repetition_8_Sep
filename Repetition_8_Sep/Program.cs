// ReSharper disable All
// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hej vad heter du?");
string namn = "Hugo";
Console.WriteLine("Jag heter " + namn);


string namn;
Console.Write("Hej vad heter du? ");
namn = Console.ReadLine();
Console.WriteLine($"Hej {namn}");



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

int tapetrulle;
int vagghojd;
int vaggbredd;
int tapetremsor;
int tapetrullar;
int tapetremsorRundat;

Console.WriteLine("Välkommen till TAPET RÄKNARE");
Console.Write("Vad är längden på din tapetrullen? ");
string tapetrulleS = Console.ReadLine();
tapetrulle = Convert.ToInt32(tapetrulleS);

Console.Write("Vad är din vägghöjd? ");
string vagghojdS = Console.ReadLine();
vagghojd = Convert.ToInt32(vagghojdS);

tapetremsor = (tapetrulle / vagghojd);

Console.WriteLine($"Då får du alltså {tapetremsor}st tapetremsor från din tapetrulle");

Console.Write("Vad är bredden på din vägg? ");
string vaggbreddS = Console.ReadLine();
vaggbredd = Convert.ToInt32(vaggbreddS);

tapetrullar = vaggbredd / tapetremsor;

Console.WriteLine($"Du behöver alltså {tapetrullar}st tapetrullar för att kunna tapetsera din vägg!");
