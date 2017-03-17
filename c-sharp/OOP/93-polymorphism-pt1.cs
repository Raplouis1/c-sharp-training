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

//•Override
//Superclass abstract Animal 
   abstract class Animal
   {
      private float weight;
      private int age;
      private int limbs;
     
      //getters/setters here
     
      //These methods below are abstract i.e. they aren't implemented in the superclass
      public abstract void Move();
      public abstract void Eat();
      public abstract void Sound();
   }

//Subclasses (mammal, reptile, fish, bird)

 class Mammal : Animal
 {
  private string furColor;
  //getters/setters here
 }
 
 class Reptile : Animal
 {
  private string scaleColor;
  //getters/setters here
 }
 
 class Fish : Animal
 {
  private string scaleColor;
  //getters/setters here
  public void makeBubble()
  {
    Console.WriteLine("Made a bubble.");
  }
 }
 
 class Bird : Animal
 {
   private string featherColor;
   //getters/setters here
   public void makeNest()
   {
    Console.WriteLine("Made a nest.");
   }
 }
 





