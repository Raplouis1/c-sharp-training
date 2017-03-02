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
 private 
 private
 private int rounds;
 private bool fightApproved;
 
 //Methods
 public void ArrangeFight(w[0], w[1])
 {
  if(w[0].WarriorClass = w[1].WarriorClass && w[0] != w[1])
  {
   fightApproved = true;
   adversary = w[0];
   challenger = w[1];
  }
  
 }
 public void FightNow()
 {
  
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
