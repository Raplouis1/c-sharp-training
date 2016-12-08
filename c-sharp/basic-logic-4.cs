// Programming logic training with C# - Flow control - for

//-----------------------------------------------------------------------

/* 1-The Fibonacci Sequence is the series of numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...
     The next number is found by adding up the two numbers before it.Ex.:The 2 is found by adding the two numbers before it (1+1)
     Knowing the informations above, write a program that calculates and shows the sequence to the 20th number.
*/

 int a = 0;
 int b = 1;
 int c; 

 for(int i = 0; i < 7; i++)//i++ = 0         i=1                     i=6   
 {                         //First loop      Second loop      Etc    Last loop
   Console.WriteLine(a);   //0               2                       2584
   Console.WriteLine(b);   //1               3                       4181
   c = a + b;              //c = 0 + 1 = 1   c = 2 + 3 = 5           .
   a = b + c;              //a = 1 + 1 = 2   a = 3 + 5 = 8           .
   b = a + c;              //b = 2 + 1 = 3   b = 8 + 5 = 13          .
   Console.WriteLine(c);   //1               5                       6765
 }
 //0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765
 //Note:0 isn't the first number in the sequence.It's the first number 1.
 
 //-----------------------------------------------------------------------
