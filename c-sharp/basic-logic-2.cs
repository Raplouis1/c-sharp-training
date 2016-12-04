//More basic programming logic training with C#.

//-----------------------------------------------------------

/* 1-Make a program that calculates how much money a person spent in cigarettes.Use the number of years that person smoke, 
number of cigarettes smoke by day and the price of a single pack(with 20 cigarettes). */

int yearsSmoking; //Example: 10 years
int numberOfCigarettesSmokePerDay; //Example: 15 cigarettes a day
double priceOfAPackOfCigarettes; //Example: 5.25
double numberOfCigarettesSmokeInAYear; 
double packsSmokedInAYear;
double moneySpentInCigarettesInAYear;
double moneySpentInCigarettesEntireLife;

Console.WriteLine("How many years have you been smoking?");
yearsSmoking = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many cigarettes do you smoke per day?");
numberOfCigarettesSmokePerDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How much costs a pack of cigarette?");
priceOfAPackOfCigarettes = Convert.ToDouble(Console.ReadLine());

numberOfCigarettesSmokeInAYear = numberOfCigarettesSmokePerDay * 365; // 15 * 365 = 5475 cigarettes per year
packsSmokedInAYear = numberOfCigarettesSmokeInAYear / 20; // 5475 / 20 = 273.75 packs
moneySpentInCigarettesInAYear = packsSmokedInAYear * priceOfAPackOfCigarettes; //273.75 * 5.25 = 1437.1875
moneySpentInCigarettesEntireLife = moneySpentInCigarettesInAYear * yearsSmoking; //1437.1875 * 10 = 14371.875

Console.WriteLine("You spend, in a year: " + moneySpentInCigarettesInAYear); //You spend, in a year: 1437.1875
Console.WriteLine("You have spent, in " + yearsSmoking + " years: " + moneySpentInCigarettesEntireLife); /*You have spent, in 10
years: 14371.875*/
Console.WriteLine("Be smart.Stop smoking!!!");

//-------------------------------------------------------








