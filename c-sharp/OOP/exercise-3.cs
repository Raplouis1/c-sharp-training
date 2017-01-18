/*Visibility (or access): indicates the level of access of the class' internal components (methods and attributes), i.e., how this items
 can be accessed.
 
 •Using UML, we can set a visual class diagram to be easy to represent the class and it's visibility:
  Example:
  ------------
  |Pen        | Class name
  ------------  
  |model      | Attributes
  |color      |
  |tipSize    |
  |penLoad    |
  |lid        |
  -------------
  |write()    | Methods
  |scribble() |
  |paint()    |
  |lidOn()    |
  |lidOff()   |
  -------------
  
  •UML Visibility modifiers:
  In the UML, there are 3 symbols that indicates the visibility:
  + public - the component can be accessed by any other components.
  - private - the component can only be accessed by the other components in the same class.
  # protected - the component can only be accessed by the other components in the same class (and this class' subclasses).  
  
  Example:  
  ------------
  |Pen        | Class name
  ------------  
  |+model      | Attributes
  |+color      |
  |-tipSize    |
  |#penLoad    |
  |#lid        |
  -------------
  |+write()    | Methods
  |+scribble() |
  |+paint()    |
  |-lidOn()    |
  |-lidOff()   |
  -------------
  
//-----------------------------------------------------------------------
  •Access modifiers in C#:
  
  •The most common types of visibility are private and public, but there are actually several other types of visibility within C#. 
  Here is a complete list: 
  -public - the member can be reached from anywhere.This is the least restrictive visibility.
    Enums and interfaces are, by default, publicly visible. 
  -private - can only be reached by members from the same class. This is the most restrictive visibility. 
    Classes and structs are by default set to private visibility.It's is the strictiest level of protection. 
  -protected - members can only be reached from within the same class, or from a class which inherits from this class. 
  -internal - members can be reached from within the same project only. 
  -protected internal - the same as internal, except that also classes which inherits from this class can reach it members, 
   even from another project. 
  
  So for instance, if you have two classes, Class1 and Class2, private members from Class1 can only be used within Class1. 
  You can't create a new instance of Class1 inside of Class2, and then expect to be able to use its private members. 

  If Class2 inherits from Class1, then only non-private members can be reached from inside of Class2.
  
  •Note: In C#, in case the access modifiers are not specified, the default modifiers are:
   -For class members and struct members, including nested classes and structs: private.
   -For classes and structs: internal.
*/

//=======================================================================
//=======================================================================

/* Using the example below, create a program in C# using access modifiers(public, private and protected):     
  ------------
  |Pen        | Class name
  ------------  
  |+model      | Attributes
  |+color      |
  |-tipSize    |  
  |#lid        |
  -------------
  |+writeSometing()| Methods
  |+status()   |  
  |-lidOn()    |
  |-lidOff()   |
  -------------
*/

//Class Pen
class Pen {
 public string model;
 public string color;
 private float tipSize;
 protected bool lid;
 
 public void writeSomething()
 {
  if (lid == true)
  {
   Console.WriteLine("The pen's lid in on.Take it off before use the pen.");
  }
   else
  {
   Console.WriteLine("You wrote: HELLO WORLD!!!");
  }
 }
 
 public void PenStatus()
 {
  Console.WriteLine("It's a " + color + " pen.");
  Console.WriteLine("The pen model is:  " + model);
  Console.WriteLine("And the tip size is: " + tipSize);
  Console.WriteLine("Is the pen lid on(true) or off(false) ? " + lid);
  Console.WriteLine("\n\n");
 }
 
 private void LidOff()
 {
  lid = false;
 }

 private void LidOn()
 {
  lid = true;
 }
 
//Main Class
 
 static void Main(string[] args)
 {
  Pen.p1 = new Pen();
  p1.model = "BIC cristal";
  p1.color = "Blue";
  //p1.tipSize = 0.5f; this two attributes are invalid because of the protection level of it's members in the class Pen
  //p1.lid = true;
  
  p1.writeSomething();
  p1.status();
  //p1.lidOn(); this two methods are invalid because of the protection level of it's members in the class Pen
  //p1.lidOff();
   
  //Note:The protected methods and attributes can be accessed later with setters and getters methods
 
 
 
 
 

