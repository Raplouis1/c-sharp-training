/* -Mini project #1 - Creating a mini Pokémon Battle 
   -Flow control structures used: if/else/if - while - switch/case
   -The PLAYER has 2 potions and the opponent got only 1(Game balance as the opponent's CHARMANDER is stronger than your Pkmn).
   -I used the random number generator function (rnd.Next(1,5); it generates a random number from 1 to 4) to make an opponent's AI.The AI choose a 
    random attack (TACKLE = -6HP and EMBER = -8HP.As EMBER is a FIRE move, it's stronger against BULBASAUR, that is a GRASS Pokémon)
    with the proportion of 3 to 1(numbers from 1 to 3 generate the TACKLE attack and the number 4 generates the EMBER attack) and
    this is used to balance the game(EMBER is strong but, only is generated a few times).
*/

 int bulbasaurHp = 50; //Your Pokémon HP. When it reaches 0, you'll lose the battle.
 int charmanderHp = 50; //Opponent's Pokémon HP. When it reaches 0, he loses.             
 char chooseKey; //chooseKey-->The player choses one action: MOVES or POTION
 char moveKey; //moveKey-->The player choses one move: TACKLE or VINE WHIP
 int potionHpRecoveryBulbasaur;            
 int playerPotionCounter = 2; //Shows how many potions still left in your bag.
 int opponentPotionCounter = 1; //Shows how many potions still left in your opponent's bag.
 Console.WriteLine("MINI POKÉMON BATTLE");
 Console.WriteLine("Welcome.Your name is ASH.You have a BULBASAUR(50HP) and 2 POTIONS(HP+20)");
 Console.WriteLine("Your opponent is GARY, your neighbour.Gary has a CHARMANDER(50HP) and 1 POTION.");

 while (bulbasaurHp > 0 && charmanderHp > 0) //Both Pokémon HP must be over 0. When one reaches 0, the while loop finishes
 {
   Console.WriteLine("IT'S YOUR TURN");
   Console.WriteLine("Press 'a' to choose MOVES");  //If the player press 'a', the loop will go to MOVES
   Console.WriteLine("Press 'b' to choose POTION"); //and if the player press 'b', the loop will go to POTION
   chooseKey = Convert.ToChar(Console.ReadLine()); //It reads one key: 'a' or 'b'

   if (chooseKey == 'a') 
   {
     Console.WriteLine("Press one of the following keys to choose a move: ");
     Console.WriteLine("Press 'x' to choose TACKLE.");
     Console.WriteLine("Press 'y' to choose VINE WHIP.");
     moveKey = Convert.ToChar(Console.ReadLine()); //It reads one key: 'x' or 'y'

     switch (moveKey)
     {
       case 'x':
         Console.WriteLine("BULBASAUR used TACKLE");
         charmanderHp -= 6; //Example: 50 - 6 = 44    
         Console.WriteLine("CHARMANDER lost 6HP");                            
         break;
       case 'y':
         Console.WriteLine("BULBASAUR used VINE WHIP");
         charmanderHp -= 4; //Example: 50 - 4 = 46
         Console.WriteLine("It's not very effective."); // as VINE WHIP is a GRASS attack, it is not very effective against
         Console.WriteLine("CHARMANDER lost 4HP");      // CHARMANDER(FIRE Pokémon).
         break;
       default:
          Console.WriteLine("Wrong key."); //If the player press one wrong key,
          break;                        //it returns to choose one key.
     }
     Console.WriteLine("CHARMANDER HP now is: "+ charmanderHp); //Shows the opponent's HP left. Example: CHARMANDER HP now is: 44
   }
   else if (chooseKey == 'b')
   {
     if (bulbasaurHp > 30 && playerPotionCounter > 0) //This 'if' is used to avoid player's Pokémon HP be over 50
     {
       Console.WriteLine("You used POTION");
       potionHpRecoveryBulbasaur = 50 - bulbasaurHp; //Example: bulbasaur HP = 36 / potionRecoveryBulbasaur = 50 - 36 = 14
       bulbasaurHp = bulbasaurHp + potionHpRecoveryBulbasaur; //bulbasaurHp = 36 + 14 = 50
       playerPotionCounter--; //Player counter = 2-1 = 1
       Console.WriteLine("BULBASAUR HP now is: " + bulbasaurHp); //BULBASAUR HP now is: 50
       Console.WriteLine("You have " +playerPotionCounter + " POTION left." ); //You have 1 POTION left.
      }
      else if (bulbasaurHp <= 30 && playerPotionCounter > 0) 
      {
        Console.WriteLine("You used POTION");
        bulbasaurHp = bulbasaurHp + 20; //Example: bulbasaurHp = 24 + 20 = 44
        playerPotionCounter--; // playerPotionCounter = 1 - 1 = 0
        Console.WriteLine("BULBASAUR HP now is: " + bulbasaurHp); //BULBASAUR HP now is: 44
        Console.WriteLine("You have " + playerPotionCounter + " POTION left."); // You have 0 POTION left.
      }
      else if (playerPotionCounter == 0) //This 'else-if' is used when the player has no POTION left.
      {
      /*When the player has no potions left, the 'if-else' continues to choose one attack moves.Otherwise, the program would jump
       right to the opponent's turn. */
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
           break;
       }
       Console.WriteLine("CHARMANDER HP now is: " + charmanderHp);
      }
     }
     if (charmanderHp > 0) //This avoid the opponent's Pokémon to attack when it has fainted.
     {
       Console.WriteLine("NOW, IT'S GARY TURN"); //It tells to the player that it's his opponent's turn
       if (charmanderHp <= 30 && opponentPotionCounter > 0)//The opponent will use one POTION when his Pokémon HP reaches 30 or less
       {                                                   //and when he has POTIONs left
         Console.WriteLine("GARY uses POTION");
         charmanderHp = charmanderHp + 20; //Example: charmanderHp = 25 + 20 = 45
         opponentPotionCounter--; //opponentPotionCounter = 0
         Console.WriteLine("CHARMANDER HP now is: " + charmanderHp); //CHARMANDER HP now is: 45
       }
       else //if the opponent has no POTIONs left, the opponent will attack 
       {
         Random rnd = new Random(); //Random object creation
         int randomNumber = rnd.Next(1, 5); //This will generates a random number between 1 and 4
         if (randomNumber < 4) // if random number is 1, 2 or 3
         {
           Console.WriteLine("CHARMANDER used TACKLE");
           bulbasaurHp = bulbasaurHp - 6; //Example: bulbasaurHp = 50 - 6 = 44
           Console.WriteLine("BULBASAUR lost 6HP");
         }
         else // else if random number is 4
         {
           Console.WriteLine("CHARMANDER used EMBER");
           bulbasaurHp = bulbasaurHp - 8; //Example: bulbasaurHp = 50 - 8 = 42
           Console.WriteLine("It's super effective!"); //as EMBER is a FIRE attack, it is very effective against
           Console.WriteLine("BULBASAUR lost 8HP");    //BULBASAUR(GRASS Pokémon).
          }
          Console.WriteLine("BULBASAUR HP now is: " + bulbasaurHp); //Example: BULBASAUR HP now is: 42
         }
        }
       }
       
       //If one of the Pokémon's HP reaches 0, the while loop finishes and :
       if (bulbasaurHp <= 0) 
       {
         Console.WriteLine("You lost.BULBASAUR fainted.");
       }
       else if (charmanderHp <= 0)
       {
         Console.WriteLine("The foe's CHARMANDER fainted.You win.You received $500.");
       }
