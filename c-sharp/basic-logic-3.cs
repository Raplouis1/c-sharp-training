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

 int a = 0;
 int i = 1;
 int remainder;
 int n;

 Console.WriteLine("Write a whole number:");
 n = Convert.ToInt32(Console.ReadLine());

 while( i < n ) //Example: n = 10 / while(i < 10)
 {
  i++;               // i++ = 1++ = 2
  remainder = i % 2; // remainder = 2 % 2 = 0
  if(remainder == 0) // 0 == 0 / true
  {                 //  a   i++
   a = a + i;       //  0 + 2 = 2 
                    //  2 + 4 = 6
                    //  6 + 6 = 12
                    // 12 + 8 = 20
                    // 20 + 10= 30
  }
 }
 Console.WriteLine(a); //30

//-----------------------------------------------------------

/* 4-Make a program that reads a whole number 'n'.Then, decides if 'n' is a prime number and shows the result.
 Note: A prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself */

 int n;
 int i = 0;
 double verification;
 int counter = 0;

 Console.WriteLine("Prime number verification.");
 Console.WriteLine("Write any whole number(starting from 2).Write 0 to finish.");
 n = Convert.ToInt32(Console.ReadLine()); //Example: n = 16

 if (n > 0 && n != 0 && n != 1) // 6 > 0 and 6 != 0 and 6 != 1 / true
 {//1st if
   do
   {//1st do
    i++;
    verification = n % i; // 6%1 = 0 
                          // 6&2 = 0
                          // 6%3 = 0
                          // 6%4 = 1.5
                          // 6%5 = 1.2
                          // 6%6 = 0
     if (verification == 0) //   6%1 = 0 / 6&2 = 0 / 6%3 = 0 / 6%6 = 0  
     {//2nd if
      counter++; // counter = 4    (+1   /    +1   /    +1   /    +1)
     }//2nd if
   } while (n != i); //1st do
   
   if (counter > 2) // counter = 4 / 4 > 2 /  true
   {//3rd if
    Console.WriteLine(n + " is not a prime number"); // 6 is not a prime number
   }//3rd if
   else
   {//1st else
     Console.WriteLine(n + " is a prime number");
   }//1st else
  }//1st if
  else
 {//2nd else
   Console.WriteLine("Invalid number");
 }//2nd else
   
//-----------------------------------------------------------

/* 6-Write a program that shows four options on a bank account: (a) Check Balance, (b) Withdraw (c)
Deposit e (d) Exit. The account balance starts at $0.00. Each time the withdraw or deposit is made, the balance
is refreshed.Example:

Options:
(a) Check Balance;
(b) Withdraw;
(c) Deposit;
> a = Check Balance
$ 0.00

Options:
(a) Check Balance;
(b) Withdraw;
(c) Deposit;
> c = Deposit
$ 20.00

Options:
(a) Check Balance;
(b) Withdraw;
(c) Deposit;
>a = Check Balance
$ 20.00

*/

 char optionKey;
 double balance = 0;
 double withdrawValue;
 double depositValue;

 Console.WriteLine("Press 'a' to check your BALANCE;");
 Console.WriteLine("Press 'b' to WITHDRAW;");
 Console.WriteLine("Press 'c' to DEPOSIT;");
 Console.WriteLine("Press 'd' to EXIT;");
 optionKey = Convert.ToChar(Console.ReadLine());

 while (optionKey != 'd')
 {
   if (optionKey == 'a')
   {
     Console.WriteLine("Seu saldo é $" + balance);                   
   }
   else if(optionKey == 'b')
   {
     if(balance == 0)
     {
       Console.WriteLine("Voce nao pode sacar.Voce nao tem dinheiro na sua conta.");
     }
     else
     {
      Console.WriteLine("Digite o quanto deseja retirar:");
      withdrawValue = Convert.ToDouble(Console.ReadLine());

        if (withdrawValue > balance)
        {
          Console.WriteLine("Saldo insuficiente.Digite outro valor.");
          continue;                            
        }
        else
        {
          balance = balance - withdrawValue;
          Console.WriteLine("Voce sacou $" + withdrawValue);                            
        }                        
       }                   
      }
      else if(optionKey == 'c')
      {
        Console.WriteLine("Digite o valor que deseja depositar:");
        depositValue = Convert.ToDouble(Console.ReadLine());
        balance = balance + depositValue;
        Console.WriteLine("Você depositou o valor de $" +depositValue);
      }
      Console.WriteLine("Pressione 'a', 'b' ou 'c' para continuar.Aperte 'd' para sair.");
      optionKey = Convert.ToChar(Console.ReadLine());
      continue;
 }
 Console.WriteLine("Voce apertou d.Operação finalizada.");

 

  
  
 
  



 
