/* -Mini project #1 - Creating a mini Pokémon Battle 
   -Flow control structures used: if/else/if - while - switch/case
   -The PLAYER has 2 potions and the opponent got only 1(Game balance as the opponent's CHARMANDER is stronger than your Pkmn).
   -I used the random number generator function (rnd.Next(1,5); //a number from 1 to 4) to make an opponent's AI.The AI choose a 
    random attack (TACKLE = -6HP and EMBER = -8HP.As EMBER is a FIRE move, it's stronger against BULBASAUR, that is a GRASS Pokémon)
    with the proportion of 3 to 1(numbers from 1 to 3 generate the TACKLE attack and the number 4 generates the EMBER attack) and
    this is used to balance the game(EMBER is strong but, only is generated a few times).
*/

 int bulbasaurHp = 50;
 int charmanderHp = 50;             
 char chooseKey, moveKey;
 int potionHpRecoveryBulbasaur;            
 int playerPotionCounter = 2;
 int opponentPotionCounter = 1;

 Console.WriteLine("MINI POKÉMON BATTLE");
 Console.WriteLine("Welcome.Your name is ASH.You have a BULBASAUR(50HP) and 2 POTION(HP+20)");
 Console.WriteLine("Your opponent is GARY, your neighbour.Gary has a CHARMANDER(50HP) and 1 POTION.");

 while (bulbasaurHp > 0 && charmanderHp > 0)
 {
   Console.WriteLine("IT'S YOUR TURN");
   Console.WriteLine("Press 'a' to choose MOVES");
   Console.WriteLine("Press 'b' to choose POTION");
   chooseKey = Convert.ToChar(Console.ReadLine());

   if (chooseKey == 'a')
   {
     Console.WriteLine("Press one of the following keys to choose a move: ");
     Console.WriteLine("Press 'x' to choose TACKLE.");
     Console.WriteLine("Press 'y' to choose VINE WHIP.");
     moveKey = Convert.ToChar(Console.ReadLine());

     switch (moveKey)
     {
       case 'x':
         Console.WriteLine("BULBASAUR used TACKLE");
         charmanderHp -= 6;
         Console.WriteLine("CHARMANDER lost 6HP");                            
         break;
       case 'y':
         Console.WriteLine("BULBASAUR used VINE WHIP");
         charmanderHp -= 4;
         Console.WriteLine("CHARMANDER lost 4HP");
         break;
       default:
          Console.WriteLine("Wrong key.");
          continue;
     }
     Console.WriteLine("CHARMANDER HP now is: "+ charmanderHp);
   }
   else if (chooseKey == 'b')
   {
     if (bulbasaurHp > 30 && playerPotionCounter > 0)
     {
       Console.WriteLine("You used POTION");
       potionHpRecoveryBulbasaur = 50 - bulbasaurHp;
       bulbasaurHp = bulbasaurHp + potionHpRecoveryBulbasaur;
       playerPotionCounter--;
       Console.WriteLine("BULBASAUR HP now is: " + bulbasaurHp);
       Console.WriteLine("You have " +playerPotionCounter + " left." );
      }
      else if (bulbasaurHp <= 30 && playerPotionCounter > 0)
      {
        Console.WriteLine("You used POTION");
        bulbasaurHp = bulbasaurHp + 20;
        playerPotionCounter--;
        Console.WriteLine("BULBASAUR HP now is: " + bulbasaurHp);
        Console.WriteLine("You have " + playerPotionCounter + " left.");
      }
      else if (playerPotionCounter == 0)
      {
       Console.WriteLine("You don't have any POTION left.");
       Console.WriteLine("Press a key to choose a move: ");
       Console.WriteLine("Press 'x' to choose TACKLE.");
       Console.WriteLine("Press 'y' to choose VINE WHIP.");
       moveKey = Convert.ToChar(Console.ReadLine());

       switch (moveKey)
       {
         case 'x':
           Console.WriteLine("BULBASAUR used TACKLE");
           charmanderHp -= 6;
           Console.WriteLine("CHARMANDER lost 6HP");
           break;
         case 'y':
           Console.WriteLine("BULBASAUR used VINE WHIP");
           charmanderHp -= 4;
           Console.WriteLine("It's not very effective.");
           Console.WriteLine("CHARMANDER lost 4HP");                                
           break;
         default:
           Console.WriteLine("Wrong key.");
           continue;
       }
       Console.WriteLine("CHARMANDER HP now is: " + charmanderHp);
      }
     }
     if (charmanderHp > 0)
     {
       Console.WriteLine("NOW, IT'S GARY TURN");
       if (charmanderHp <= 30 && opponentPotionCounter > 0)
       {
         Console.WriteLine("GARY uses POTION");
         charmanderHp = charmanderHp + 20;
         opponentPotionCounter--;
         Console.WriteLine("CHARMANDER HP now is: " + charmanderHp);
       }
       else 
       {
         Random rnd = new Random();
         int randomNumber = rnd.Next(1, 5);
         if (randomNumber < 4)
         {
           Console.WriteLine("CHARMANDER used TACKLE");
           bulbasaurHp = bulbasaurHp - 6;
           Console.WriteLine("BULBASAUR lost 6HP");
         }
         else
         {
           Console.WriteLine("CHARMANDER used EMBER");
           bulbasaurHp = bulbasaurHp - 8;
           Console.WriteLine("It's super effective!");
           Console.WriteLine("BULBASAUR lost 8HP");
          }
          Console.WriteLine("BULBASAUR HP now is: " + bulbasaurHp);
         }
        }
       }
       
       if (bulbasaurHp <= 0)
       {
         Console.WriteLine("You lost.BULBASAUR fainted.");
       }
       else if (charmanderHp <= 0)
       {
         Console.WriteLine("The foe's CHARMANDER fainted.You win.You received $500.");
       }
