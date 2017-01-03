//Basic programming logic with C#.

//--------------------------------------------------------

//1-Make a program that gets two grades and their respective weights and, then, calculates the Weighted Average of those two grades.

static void Main(string[] args)
{
  double gradeA; //Example: gradeA = 6
  double gradeB; //Example: gradeB = 8
  int weightGradeA; //Example: weightGradeA = 1
  int weightGradeB; //Example: weightGradeB = 2
  
  Console.WriteLine("Write the first grade:");
  gradeA = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Write the first grade's weight:");
  weightGradeA = Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine("Write the second grade:");
  gradeB = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Write the second grade's weight:");
  weightGradeB = Convert.ToInt32(Console.ReadLine());
  
  // Example: gradeA = 6 / gradeB = 8 / weightGradeA = 1 / weightGradeB = 2                         
  
  double weightedAverage = Math.Round((gradeA * weightGradeA) + (gradeB * weightGradeB)) / 2 , 1);
  //weightedAverage = ( (6 * 1) + (8 * 2) ) / 2 => (6+16) / 2 =>  22 / 2 = 11
  
  Console.WriteLine("Your weighted average is:");  
  Console.WriteLine(weightedAverage); //11
  
}

//-------------------------------------------------------

//2-Make a program that calculates an circle area(circle area is equal to πr²).
  
  double radius; //Example: radius = 2.3
  Console.WriteLine("Write the radius of the circle:"); 
  radius = Convert.ToDouble(ReadLine()); 
  double area = Math.Round(3.14 * Math.Pow(radius,2) , 1); //3.14 * 2.3² = 3.14 * 5.29 = 16.6106 -->rounded = 16.6
  Console.WriteLine("The circle area is: " + area); //The circle area is: 16.6

//------------------------------------------------------

/*3-Make a program that reads the user's year of birth and the current year
then calculates and shows:
(a) the user's current age;
(b) the user's age in 2050; */ 
 
 int userYearOfBirth;
 int currentYear;
 int userCurrentAge;
 int userAgeIn2050;

 Console.WriteLine("Write the year you were born:");
 userYearOfBirth = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Write the current year:");
 currentYear = Convert.ToInt32(Console.ReadLine());

 userCurrentAge = currentYear - userYearOfBirth;
 userAgeIn2050 = 2050 - userYearOfBirth;

 Console.WriteLine("Your current age is: " + userCurrentAge);
 Console.WriteLine("Your age in 2050 will be: " + userAgeIn2050);

//----------------------------------------------------------

/*4. Make a program that reads the user's monthly number of worked hours and the monthly minimum wage value,  
 then calculates and writes the salary to be received in the end of the month, following the rules:
(a) Every worked hour worths 1/4 of the minimum wage;
(b) The gross salary is equal to the monthly worked hours times the value of each hour;
(c) The income tax is equal to 3% of the gross salary;
(d) The salary to be received is equal to the gross salary minus the tax. */
 
 
 double monthlyWorkedHours; //Example: 160
 double monthlyMinimumWage; //Example: 1000
 
 double eachHourValue;
 double grossSalary;
 double incomeTax;
 double finalSalary; 

 Console.WriteLine("Write how many hours you worked last month:");
 monthlyWorkedHours = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Write the minimum wage's value:");
 monthlyMinimumWage = Convert.ToDouble(Console.ReadLine());
 
 eachHourValue = monthlyMinimumWage / 4; // 1000 / 4 = 250
 grossSalary = monthlyWorkedHours * eachHourValue; // 160 * 250 = 40000 
 incomeTax = grossSalary * 0.03; // 40000 * 0.03 = 1200
 finalSalary = grossSalary - incomeTax; // 40000 - 1200 = 38800

 Console.WriteLine("Your monthly salary is: " + finalSalary); //Your monthly salary is: 38800

//------------------------------------------------------------

/*5-Write a program that reads a employee's salary, calculates and write the new salary, supposing the employee got a salary 
raise of 25%.Then, show that new salary with a discount of 10%. */

 double currentSalary;
 double raisePercentageOf25Percent = 0.25;
 double newSalaryWith25PercentRaise;
 double discountPercentageOf10Percent = 0.1;
 double salaryAfter10PercentDiscount;

 Console.WriteLine("Write the employee's current salary:");
 currentSalary = Convert.ToDouble(Console.ReadLine());

 newSalaryWith25PercentRaise = currentSalary + (currentSalary * raisePercentageOf25Percent);
 salaryAfter10PercentDiscount = newSalaryWith25PercentRaise - (newSalaryWith25PercentRaise * discountPercentageOf10Percent);

 Console.WriteLine("The new salary, with a raise of 25% is:" + newSalaryWith25PercentRaise);
 Console.WriteLine("But, as the employee got a discount of 10%, the salary will be: " + salaryAfter10PercentDiscount);

/* 6-Make a program that calculates how much money a person spent in cigarettes.Use the number of years that person smoke, 
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
 
