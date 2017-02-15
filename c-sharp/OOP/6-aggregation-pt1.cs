//Creating a class to be aggregate in the next exercise.

class Warrior
{
   private string name, nationality, warriorClass;   
   private int age, wins, defeats, draws;
   private float height, weight;  
   
   
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
  public void Announcement()
  {
     Console.WriteLine("Fighter: " + Nome);
     Console.WriteLine("From: " + Nationality);
     Console.WriteLine(Age + " years old");
     Console.WriteLine(Height + "m");
     Console.WriteLine(Weight + "kg");
     Console.WriteLine(Wins + " wins.");
     Console.WriteLine(Defeats + " defeats.");
     Console.WriteLine(Draws + " draws");        
  }
  public void Status()
  {
     Console.WriteLine(Name);
     Console.WriteLine(WarriorClass);
     Console.WriteLine(Wins);
     Console.WriteLine(Defeats);
     Console.WriteLine(Draws);     
  }   
}

//==============================================================

//Main class
static void Main(string[] args)
{
   Warrior w[] = new Warrior[6];//6 is the amount of items we can put inside the array
   w[0] = new Warrior("Ninja", "Japan", 31, 1.75f, 68.9f, 11, 2, 1);
   w[1] = new Warrior("Capoeira", "Brazil", 29, 1.68f, 57.8f, 14, 2, 3);
   w[2] = new Warrior("Marine", "USA", 35, 1.9f, 80.9f, 12, 2, 1);
   w[3] = new Warrior("Kung Fu", "China", 28, 1.93f, 81.6f, 13, 0, 2);
   w[4] = new Warrior("Krav Maga", "Israel", 37, 1.7f, 119.3f, 5, 4, 3);
   w[5] = new Warrior("Sumo", "Japan", 30, 1.6f, 120f, 12, 2, 4);
   
}
