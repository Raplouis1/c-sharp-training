// Programming logic training with C# - Control flow - while / do-while

//-----------------------------------------------------------

// 1-Write a program that shows odd numbers between 1 and 100
 int i = 0;
 int control;

 while( i >= 1 && i < 100)
 {
   i++;
   if(control != 0)
   {
     Console.WriteLine(i);
   }
 }

//-----------------------------------------------------------

// 2-Write a program that reads a whole number 'n'.Then, shows the sum of all numbers from 1 to 'n'.
 
 int a = 1;
 int i = 1;
 int n;
 
 Console.WriteLine("Write a whole number:");
 n = Convert.ToInt32(Console.ReadLine()); //Example: n = 10
 
 while( i < n ) // ( i < 10 )
 {
  i++; //i=2  / a    i++ 
  a = a + i; //  1 + 2 = 3 
             //  3 + 3 = 6
             //  6 + 4 = 10
             // 10 + 5 = 15
             // 15 + 6 = 21
             // 21 + 7 = 28
             // 28 + 8 = 36
             // 36 + 9 = 45
             // 45 + 10= 55
 }
 Console.Writeline(i); //55

//-----------------------------------------------------------

// 3-Write a program to read a whole number 'n'.Then, shows the sum of all even number from 2 to 'n'.

 int a = 1;
 int i = 0;
 int remainder;
 int n;

 Console.WriteLine("Write a whole number:");
 n = Convert.ToInt32(Console.ReadLine());

 while( i < n)
 {
  i++;
  remainder = i % 2;
  if(remainder == 0)
  {
   a = a + i;
  }
 }
 Console.WriteLine(a);

 
