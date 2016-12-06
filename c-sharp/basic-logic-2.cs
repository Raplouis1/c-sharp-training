//Programming logic training with C#.Control flow - if/else

//-----------------------------------------------------------

/* 1-Make a program to solve a quadratic equation(x² + bx + c = 0).The program asks for the user to enter the value
 of a, b and c. Note: Delta(discriminant) = b² - 4ac and Bhaskara = (-b ±√Delta) / 2a  */

 double a, b, c, x1, x2;
 double delta;
 
 Console.WriteLine("Write the 'a' value:");
 a = Convert.ToDouble(Console.ReadLine()); //Example: a = 1
 Console.WriteLine("Write the 'b' value:"); 
 b = Convert.ToDouble(Console.ReadLine()); //Example: b = 6
 Console.WriteLine("Write the 'c' value:");
 c = Convert.ToDouble(Console.ReadLine()); //Example: c = 2

 delta = Math.Pow(b,2) - ( 4 * a * c ); // delta = 6² - (4 * 1 * 2) = 36 - 8 = 28
 x1 = ((-1 * b) + Math.Sqrt(delta)) / (2*a); // x1 = -0.4
 x2 = ((-1 * b) - Math.Sqrt(delta)) / (2*a); // x2 = -5.6
   
 if (delta  > 0) 
 {
  Console.WriteLine("This equation has two solutions.");
  Console.WriteLine("Delta is equal to " + delta);
  Console.WriteLine("X1 is " + x1 + " and " + "X2 is " + x2);
 }
 else if(delta == 0)
 {
   Console.WriteLine("This equation has only one solution.");
   Console.WriteLine("Delta is equal to " + delta);
   Console.WriteLine("X is " + x1);
 }
 else
 {
    Console.WriteLine("Delta is negative.This equation has no solution.");
 }

//-----------------------------------------------------------

// 2-Make a program that reads a whole number and tells if it is multiple of 3 and 4 at the same time.

 int number;
 int multipleVerification3;
 int multipleVerification4;

 Console.WriteLine("Write a whole number:");
 number = Convert.ToInt32(Console.ReadLine()); //Example: 12
 multipleVerification3 = number % 3; //12 % 3 = 0
 multipleVerification4 = number % 4; //12 % 4 = 0

 if(multipleVerification3 == 0 && multipleVerification4 == 0) //Both conditions are true
 {
   Console.WriteLine(number + " is multiple of both 3 and 4."); //Shows this message
 }
 else
 {
   Console.WriteLine(number + " is not multiple of both 3 and 4");
 }

//-----------------------------------------------------------

/* 3-A hotel charges $60 per day plus service tax.The service tax is:
   $55 per day, if the customer stays for more than 15 days;
   $60 per day, if the customer stays exactly 15 days; 
   $80 per day, if the customer stays less than 15 days;
   Write a program that shows the costumer name and bill.
*/

 string name, surname;
 int numberOfDaysStayed;
 double serviceTax, bill;
 double chargePerDay = 60;
 
 Console.WriteLine("Write the costumer's name and surname:");
 name = Console.ReadLine(); //Example: Jimi
 surname = Console.ReadLine(); //Example: Hendrix
 Console.WriteLine("Write how long the costumer stayed:");
 numberOfDaysStayed = Convert.ToInt32(Console.ReadLine()); //Example: 10
 
 
 if(numberOfDaysStayed > 15)
 {
  serviceTax = 55;  
 }
 else if(numberOfDaysStayed == 15)
 {
  serviceTax = 60;  
 }
 else //this condition is true
 {
   serviceTax = 80;   
 } 
 
 bill = (chargePerDay + serviceTax) * numberOfDaysStayed; // bill = (60 + 80) * 10 = 140 * 10 = 1400
 Console.WriteLine("Mr's/Ms'"+ surname + " bill is: $" + bill); //Mr's/Ms' Hendrix bill is: $1400

//-----------------------------------------------------------

// 4- Write a C# program that prompts the user to input three integer values and find the greatest value of the three values.

 int a;
 int b;
 int c;

 Console.WriteLine("Write three integer numbers:");
 a = Convert.ToInt32(Console.ReadLine());
 b = Convert.ToInt32(Console.ReadLine());
 c = Convert.ToInt32(Console.ReadLine());

 if(a > b && a > c)
 {
  Console.WriteLine("The first number, " + a + " is the greatest of the three numbers.");
 }
 else if(b > a && b > c)
 {
  Console.WriteLine("The second number, " + b + " is the greatest of the three numbers.");
 }
 else
 {
  Console.WriteLine("The third number, " + c + " is the greatest of the three numbers.");
 }

//-----------------------------------------------------------

/* 5-Write a programa that shows if a number is between 20 and 90 or not. */

 double a;
 
 Console.WriteLine("Write any number:");
 a = Convert.ToDouble(Console.ReadLine());

 if(a >= 20 && a<=90)
 {
  Console.WriteLine("Your number is between 20 and 90.");
 }
 else()
 {
  Console.WriteLine("Your number isn't between 20 and 90.");
 }

//-----------------------------------------------------------



  
   
 










