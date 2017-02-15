//Creating a class to be aggregate in the next exercise.

class Warrior
{
   private string name;
   private string nationality;
   private int age;
   private float height;
   private float weight;
   private string warriorClass;
   private int wins;
   private int defeats;
   private int draws;
   
   //Constructor method
   public Warrior(string name, string nationality, int age, float height, float weight, int wins, int defeats, int draws)
   {
      this.name = name;
      this.nationality;
      this.age = age;
      this.height = height;
      this.weight = Weight; //Weight is a setter property
      this.wins = wins;
      this.defeats = defeats;
      this.draws = draws; 
      //Note: warriorClass will be set automatically later in the program
   }
   
   //Properties   
   public string Name
   {
     get{ return name; }
     set{ name = value; }
   }
   
   public string Nationality
   {
     get{ return nationality; }
     set{ nationality = value; }
   }
   
   public int Age
   {
     get{ return age; }
     set{ age = value; }
   }
   
   public float Height
   {
     get{ return height; }
     set{ height = value; }
   }
   
   public float Weight
   {
     get{ return weight; }
     set
     {
       weight = value;
       WarriorClass;//(set)WarriorClass
     }
   }
  
   private string WarriorClass //It's private because only the program can change it
   {
     get{ return warriorClass; }
     set
     {
       if(weight < 52.2 || weight > 120.2)
       {
         warriorClass = "Unable to fight.";
       }else if(weight <= 70.3){
         warriorClass = "Lightweight";
       }else if(weight <= 83.9){
         warriorClass = "Middleweight";
       }else{
         warriorClass = "Heavyweight";
       }         
     }
   }
   
   public int Wins
   {
     get{ return wins; }
     set{ wins = value; }
   }
   
   public int Defeats
   {
     get{ return defeats; }
     set{ defeats = value; }
   }
   
   public int Draws
   {
     get{ return draws; }
     set{ draws = value; }
   }
  
  //Methods  
  public void WinFight()
  {
    Wins += 1;
  }
  public void LostFight()
  {
    Defeats += 1;
  }
  public void DrawFight()
  {
    Draws += 1;
  }
  
   
}
