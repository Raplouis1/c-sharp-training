/*
•Polymorphism: word that comes from Greek language (Poly = "many, much", Morphos = "shape, form") meaning 
 "something that can have multiple shapes/forms and/or behaviors".
 
•Method signature: 
  -Every method can or cannot receive arguments(parameters). The quantity and types of it's arguments will define
  it's signature.
  -Every method has it own signature.
  
   -Example: 
   -public void calculateGPA(float n1, float n2)
    {
     ...
     return float x;
    }
    
   -public void calculateGPA(float v1, float v2)
    {
     ...
     return int y;
    }
    
   -Despite of the arguments (float n1, float n2 / float v1, float v2) in the two methods having different names, their types(float, float)
   and quantity(2 in the first method and 2 in the second method) are the same, making the signature in both methods the same.
     
   -public void calculateGPA(int term, float n1, float n2)
   {
    ...
   }
   -The method above have 3 arguments(term, n1, n2) and 3 types (int, float, float) and it is different from the two mthods above.
 
 •These are them most common polymorphism kinds:
  -Override and Overload
  -Below, we're going to create two programs to show how each kind works.    
 
*/


//====================================================================================

//•Override: occurs when we substitute a superclass' method in the subclass using the same method's signature
//Example: 
 //Superclass: public abstract void ExampleMethod();
 //Subclass: public override void ExampleMethod(){ //code here }

//Superclass abstract Animal 
   abstract class Animal
   {
      private float weight;
      private int age;
      private int limbs;
     
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Limbs
        {
            get { return limbs; }
            set { limbs = value; }
        }
     
      //These methods below are abstract i.e. they aren't implemented in the superclass
      public abstract void Move();
      public abstract void Eat();
      public abstract void Sound();
   }

//Subclasses (mammal, reptile, fish, bird)
 class Mammal : Animal
 {
  private string furColor;
  
        public string FurColor
        {
            get { return furColor; }
            set { furColor = value; }
        }
        //The methods below will override the method in the abstract class
        public override void Move() 
        {
            Console.WriteLine("Running.");
        }
        public override void Eat()
        {
            Console.WriteLine("Breastfeeded.");
        }
        public override void Sound()
        {
            Console.WriteLine("Mammal sound.");
        }
 }
 //---
 class Reptile : Animal
 {
  private string scaleColor;
  
        public string ScaleColor
        {
            get { return scaleColor; }
            set { scaleColor = value; }
        }
        //The methods below will override the method in the abstract class
        public override void Move()
        {
            Console.WriteLine("Crawling.");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat little animals.");
        }
        public override void Sound()
        {
            Console.WriteLine("Reptile sound.");
        }
 }
 //---
 class Fish : Animal
 {
  private string scaleColor;
  
        public string ScaleColor
        {
            get { return scaleColor; }
            set { scaleColor = value; }
        }
        //The methods below will override the method in the abstract class
        public override void Move()
        {
            Console.WriteLine("Swimming.");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat seaweed.");
        }
        public override void Sound()
        {
            Console.WriteLine("No sound.");
        }
        //---
        public void MakeBubbles()
        {
            Console.WriteLine("Bubbles.BloobBloobBloob");
        }
 }
 //---
 class Bird : Animal
 {
   private string featherColor;
   //getters/setters here
        public string FeatherColor
        {
            get { return featherColor; }
            set { featherColor = value; }
        }
        //The methods below will override the method in the abstract class
        public override void Move()
        {
            Console.WriteLine("Flying.");
        }
        public override void Eat()
        {
            Console.WriteLine("Eat Little insects.");
        }
        public override void Sound()
        {
            Console.WriteLine("Bird sound.");
        }
        //---
        public void MakeANest()
        {
            Console.WriteLine("Made a nest.");
        }
 }
 
//Sub-subclass: turtle
public class Turtle : Reptile
{
  public override Move()
  {
   Console.WriteLine("Slowly movement");
  }
}
 
//Main class
    class Program
    {
        static void Main(string[] args)
        {
          //Animal a1 = new Animal();  This object cannot be created as Animal is an abstract class
          Mammal m1 = new Mammal();
          Reptile r1 = new Reptile();
          Fish f1 = new Fish();
          Bird b1 = new Bird();
          Turtle t1 = new Turtle();
          
          m1.setWeight = 15.5;
          m1.setAge = 20;
          m1.setLimbs = 4;
          m1.Move();  //Running
          m1.Eat(); //Breastfeeded
          m1.Sound(); //Mammal sound
         
          f1.setWeight = 4;
          f1.setAge = 5;
          f1.setLimbs = 0;
          f1.Move(); //Swimming
          f1.Eat(); //Eat seaweed
          f1.Sound(); //No sound
          f1.MakeBubbles(); //Bubbles.BloobBloobBloob
         
          t1.Move(); //Slowly movement
          
          //Note that even the methods being the same, the outputs will be different due the override polymorphism
        }
    }
 
//====================================================================================
//•Overload: the same method with different signatures in the same class
//Example: using the method ReactTo() , create multiple methods using the Overload concept:
public class Dog : Animal
{
  //Note that the three methods below have the same name(ReactTo) with different signatures(string / int / bool)
  public void ReactTo(string command)
  {
    if(command == "Sit" || "Lay down")
    {
     Console.WriteLine("Command obeyed.Good boy.");
    }else{
     Console.WriteLine("Did nothing.");
    }
  }
  public void ReactTo(int hour)
  {
    if(hour < 12)
    {
      Console.WriteLine("Dog is sleeping.");
    }else if(Hour == 00){
      Console.WriteLine("Bark at the moon.");
    }
  }
  public void ReactTo(bool owner)
  {
    if(owner == true)
    {
     Console.WriteLine("Playing.");
    }else{
     Console.WriteLine("Stranger!!!Woof!!Woof!!");
    }
  }

}

//Main Class
static void Main()
{
  Dog d1 = new Dog();
  
  d1.ReactTo("Sit"); //Command obeyed.Good boy.
  d1.ReactTo(00); //Bark at the moon. 
  d1.ReactTo(false); //Stranger!!!Woof!!Woof!
}

//====================================================================================
//Tips to remember the polymorphisms kinds:
//•Override: same (methods) signature, different classes
//•Overload: different (methods) signatures, same class





