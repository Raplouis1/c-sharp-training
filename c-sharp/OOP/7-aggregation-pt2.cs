//Aggregation part 2
/*
•Aggregation: it's a special kind of classes relationship.Example(based on the previous exercise):
 w[0] = new Warrior("Ninja", "Japan", 31, 1.75f, 68.9f, 11, 2, 1); //Warrior 1
 w[1] = new Warrior("Capoeira", "Brazil", 29, 1.68f, 57.8f, 14, 2, 3); //Warrior 2
-We need to create a class to make them fight.The class is called "Fight":
 -Class: Fight
 -Attributes(- is private ): 
  -adversary(who was challenged): abstract 
  -challenger(who asked for a fight): abstract
  -rounds: int
  -fightApproved: bool //Show if this fights is according with the tournament rules(see it below)
 -Methods:
  +ArrangeFight()
  +FightNow()
  setters/getters
  
  -The aggregation is represented in uml by an arrow with the diamond geometrical shape as tip:
             (-->Warrior(s) disputes one(or more) Fight(s)-->)    
   Warrior ---------------------------------------------------<> Fight
                (<--a Fight is disputed by Warrior(s)<--)
   i.e. class B(Fight) has one (or more) attributes from class A(Warrior).This is aggregation.
   
   -Tournament rules:
    1-Fights can only be arranged by Warrior from the same category
    2-Challenger and adversary must be different
    3-Fight should only be started if it's approved
    4-Fight result can only be: one warrior won or the fight drew

*/

//----------------------------------------------------------------------------------

//Now, we're going to create our class Fight:

class Fight
{
 //Attributes
 private Warrior adversary;
 private Warrior challenger;
 private int rounds;
 private bool fightApproved;
 
 //Methods
 public void ArrangeFight(Warrior w1, Warrior w2)
 {
  if(w1.WarriorClass == w1.WarriorClass && w1 != w2)
  {
   fightApproved = true;
   adversary = w1;
   challenger = w2;
  }else{
   fightApproved = false;
   adversary = null;
   challenger = null;
  }  
 }
 public void FightNow()
 {
  if(fightApproved == true)
  {
   adversary.Announcement();
   challenger.Announcement();    
   Random random = new Random();
   int winner = random.Next(0, 3);//3 is not included - 0 is draw, 1 adversary wins and 2 chalenger wins
   Console.WriteLine("---Fight Result---");
   switch(winner)
   {
    case 0:
     Console.WriteLine("Draw!!!");
     adversary.DrawFight();
     challenger.DrawFight();
     break;
    case 1:
     Console.WriteLine("Adversary win." + adversary.Name);
     adversary.WinFight();
     challenger.LostFight();
     break;
    case 2:
     Console.WriteLine("Challenger win." + challenger.Name);
     challenger.WinFight();
     adversary.LostFight();
     break;
   }
   
  }else{
   Console.WriteLine("This fight cannot happen!!!");
  }
  
 }
 //Setters and Getters
 public Warrior
 {
 }
 public Warrior
 {
 }
 public int Rounds
 {
  get{return rounds;}
  set{rounds = value;}
 }
 public bool FightApproved
 {
  get{return fightApproved;}
  set{fightApproved = value;}
 }
 
}

//Main class
static void Main(string[] args)
{   
   
   Warrior[] w = new Warrior[6];
   w[0] = new Warrior("Ninja", "Japan", 31, 1.75f, 68.9f, 11, 2, 1);
   w[1] = new Warrior("Capoeira", "Brazil", 29, 1.68f, 57.8f, 14, 2, 3);
   w[2] = new Warrior("Marine", "USA", 35, 1.9f, 80.9f, 12, 2, 1);
   w[3] = new Warrior("Kung Fu", "China", 28, 1.93f, 81.6f, 13, 0, 2);
   w[4] = new Warrior("Krav Maga", "Israel", 37, 1.7f, 119.3f, 5, 4, 3);
   w[5] = new Warrior("Sumo", "Japan", 30, 1.6f, 120f, 12, 2, 4);
   
   Fight F1 = new Fight();
   F1.ArrangeFight(w[0], w[1]);
   F1.FightNow();
   w[0].Status();
   w[1].Status();
}
/* OUTPUT:
---Adversary---
Fighter: Ninja
From: Japan
31 years old
1.75m
68.9kg
11 wins.
2 defeats.
1 draws
---Challenger---
Fighter: Capoeira
From: Brazil
29 years old
1.68m
57.8kg
14 wins.
2 defeats.
3 draws
---Fight Result---
Adversary Wins!!!Ninja
Ninja
Lightweight.
12
2
1
Capoeira
Lightweight.
14
3
3
*/
