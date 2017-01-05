/*Here, I train the basic OOP concepts:
 What is:
 -an object;
 -a class;
 -a method.
 
*/

//=======================================================================
//=======================================================================

/*Use the object PEN as an example to this exercise.Classify the pen (show it's attributes and methods ), then create, in C#, 
 a basic program to shows it's classifications(don't forget to create it's class and the object). */

/*
--Object: Pen (Bic Cristal)
--Attributes:
 -Model: Cristal
 -Color: Blue
 -Tip size: 1.6
 -Lid
--Methods:
 -Write
 -Take the lid off
*/
 
class Pen //This is the class Pen. So, all kind of objects "pen" wil have this class' attributes and methods
{
 //These are the class' attributes
 string model; //Pen's model
 string color; //Pen's color
 float tipSize; //Pen's tip diameter
 boolean lid = true; //The lid in on the pen
 
 //These are the class' methods
 public void WriteSometing()
 {
  if (lid == true)
  {
   Console.WriteLine("The lid is on.Take it off before write.");
  }
  else
  {
   Console.WriteLine("You wrote: Hello World!!!");
  }
 } 
 
 public void LidOff()
 {
  lid = false;
 }
}

//------------------------------------------------------------

//Main Class

static void main (string[] args)
{
 Pen p1 = new Pen; //It's the object(pen - p1). -->Syntax: <class> <object's name> = <instance> <class>;
 p1.model = "Cristal" //This is one of the object's attributes. -->Syntax: <object's name>.<attribute> = <value>
 p1.color = "Blue";
 p1.tipSize = 1.6;
 p1.WriteSometing();//This is one of the object's methods. --> Syntax: <object's name>.<method's name>(<parameter>);
 p1.LidOff();
}

//=======================================================================
//=======================================================================
