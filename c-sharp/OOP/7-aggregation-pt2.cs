//Aggregation part 2
/*
•Aggregation: it's a special kind of classes relationship.Example(based on the previous exercise):
 w[0] = new Warrior("Ninja", "Japan", 31, 1.75f, 68.9f, 11, 2, 1); //Warrior 1
 w[1] = new Warrior("Capoeira", "Brazil", 29, 1.68f, 57.8f, 14, 2, 3); //Warrior 2
 We need to create a class to make them fight.The class is called "Fight":
 -Class: Fight
 -Attributes(- is private ): 
  -adversary(who was challenged): abstract 
  -challenger(who asked for a fight): abstract
  -rounds: int
  -fightApproved: bool //Show if this fights is according with the tournament rules
 -Methods:
  +ArrangeFight()
  +FightNow()
  setters/getters
  
  -The aggregation is represented in uml by an arrow with the diamond geometrical shape as tip:
             (-->Warrior(s) disputes one(or more) Fight(s)-->)    
   Warrior ---------------------------------------------------<> Fight
                (<--a Fight is disputed by Warrior(s)<--)
   

*/
