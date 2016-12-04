//More basic programming logic training with C#.

//-----------------------------------------------------------

/* 1-Make a program that calculates how much money a person spent in cigarettes.Use the number of years that person smoke, 
number of cigarettes smoke by day and the price of a single pack(with 20 cigarettes). */

int yearsSmoking;
int numberOfCigarettesSmokePerDay;
double priceOfAPackOfCigarettes;
int numberOfCigarettesSmokeInAYear;
double packsSmokedInAYear;
double moneySpentInCigarettesInAYear;
double moneySpentInCigarettesEntireLife;

Console.WriteLine("How many years have you been smoking?");
yearsSmoking = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many cigarettes do you smoke per day?");
numberOfCigarettesSmokePerDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How much costs a pack of cigarette?");
priceOfAPackOfCigarettes = Convert.ToDouble(Console.ReadLine());

numberOfCigarettesSmokeInAYear = numberOfCigarettesSmokePerDay * 365;
packsSmokedInAYear = numberOfCigarettesSmokeInAYear / 20;
moneySpentInCigarettesInAYear = packsSmokedInAYear * priceOfAPackOfCigarettes;
moneySpentInCigarettesEntireLife = (yearsSmoking * packsSmokedInAYear) * priceOfAPackOfCigarettes;

Console.WriteLine("You spend, in a year," + moneySpentInCigarettesInAYear);
Console.WriteLine("You have spent, in " + yearsSmoking + "years, " + moneySpentInCigarettesEntireLife);
Console.WriteLine("Stop smoking!!!");






