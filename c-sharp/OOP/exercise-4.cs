//Properties (Get, Set) and Constructors Methods

/*
 •Get and Set Properties: They're used to access protected attributes and methods inside a class.
  Syntax -> <visibility><type><same name of it's attribute>{ get { return <attribute>; } set { <attribute> = value; } }
  Example:public class PropertiesExample
           {
            private string firstAttribute;
            
            public string FirstAttribute
            {
             get { return firstAttribute; } //This returns the attributes value
             set { firstAttribute = value; } //This sets an attribute's value
            }
            
            //Main Class
            
            class Program
            {
             static void Main (string[] args)
             {
              PropertiesExample e1 = new PropertiesExample();
              e1.FirstAttribute = "Hello World!"; 
              //This calls the set property(note that the first letter of "FirstAttribute" must be in upper case in order to 
              //call the 'set' property. Otherwise, it will try to call the regular attribute, the program will not work). 
              
              Console.WriteLine("Your attribute is: " + e1.FirstAttribute); 
              // This will call the 'get' property (same rule as calling the 'set' property applies here).
             }
            } 
            

  •Constructor methods: special methods used when instantiating a class(i.e. initilizating an object).They don't return anything. 
   They can be used to set default attributes to an object. So, every object created from a class will have those default attributes.
   Syntax -> <visibility><same name of it's class>(<parameters>)
   Example: public class ConstructorExample
            {
             public string constructorName;
             public int constructNumber;            
             
             public ConstructorExample() //The method's name is the same it's class.           
             { 
              constructorName = "My name is Example!!!";
              constructorNumber = 1;
             }
             //In this example, every object created from the "Constructor Example" class will have this attributes
             //as default.
             
             public ConstructorExample(string constructorName, int constructorNumber)
             {
              this.constructorName = constructorName;
              this.constructorNumber = constructorNumber;
             }
             //Through this constructor, you can set the attribute's value you want.
             
             //Main Class
             class Program
             {
              static void Main(string[] args)
              {
               ConstructorExample e1 = new ConstructorExample();
               ConstructorExample e2 = new ConstructorExample("My name is Example 2!!!", 2);
               Console.WriteLine("What is your name? " + e1.constructorName + "Number: " + e1.constructorNumber);
               Console.WriteLine("What is your name? " + e2.constructorName + "Number: " + e2.constructorNumber);
              }
             }
*/


//===========================================================================

/*1 - Get and Set exercise.
A college student want to have access to his status in the college (tuition loan debt, gpa, current semester etc).
However, those informations are secured and can only be requested in the college's office of academic and 
financial services. Using get and set properties, write a program that shows the student informations.
*/

//Class StudentStatus
class StudentStatus
{
  public string name;
  private int loanDebt;
  private float gpa;
  private string currentSemester;
  
  public int LoanDebt
  {
    get{ return loanDebt;}
    set{ loanDebt = value;}
  }
  
  public float Gpa
  {
    get{ return gpa;}
    set{ gpa = value;}
  }
  public string CurrentSemester
  {
    get{ return currentSemester;}
    set{ currentSemester = value;}
  }
  
  public void Status()
  {
    Console.WriteLine("Hello, " + name);
    Console.WriteLine("Your debt is: " + loanDebt);
    Console.WriteLine("Your GPA is: " + gpa);
    Console.WriteLine("You're in the " + currentSemester + " semester");
  }
  /*
  Or, you can write the method above like this:
  public void Status()
  {
    Console.WriteLine("Hello, " + name);
    Console.WriteLine("Your debt is: " + LoanDebt);
    Console.WriteLine("Your GPA is: " + Gpa);
    Console.WriteLine("You're in the " + CurrentSemester + " semester");
  }
  */
}

//Main class
class Program
{
  static void main (string[] args)
  {
    StudentStatus ss1 = new StudentStatus();
    ss1.name = "Joseph";
    ss1.setLoanDebt = 50000;
    ss1.setGpa = 3.6f;
    ss1.setCurrentSemester = "last";
    
    ss1.Status();
    /*
    Instead of the method above, you can use this:
    Console.WriteLine("Hello, " + ss1.name + "\nYour student loan is: " + ss1.LoanDebt + "Your GPA is: " + ss1.Gpa + 
    "\nYou're in the " + ss1.CurrentSemester + " semester");  */  
    
    /*
    NOTE:
    -Different from Java, get and set properties in C# dont't need the get/set reference before an attribute.
     -Example: Set in java: e1.setExampleName("It´s just an example."); 
               Set in C#: e1.ExampleName = "It´s just an example"; //This set the object attribute to "It´s just an example."
               Get in Java: System.Out.Println("What is it? " + e1.getExampleName());
               Get in C#: Console.WriteLine("What is it? " + e1.ExampleName); //This get the object attribute "It´s just an example."
    */
  }
  /*Output
  Hello, Joseph
  Your debt is: 50000
  Your GPA is: 3.6
  You're in the last semester
  */
}  

//===========================================================================

/*2-Constructor method exercise.
 A car industry want a system to register every car it produces.Knowing that every car comes with default parts 
 and characteristics(ABS brakes, Airbag and Mileage) as well as knowing each car comes with particular parts and characteristics
 (model, color, finalMph), write a program to register those cars. 
*/

//Class Car
public class Car
{
 public bool absBrakes;
 public bool airbag;
 public int mileage;
 public string model;
 public string color;
 public int finalMph;
 
 public Car() //Default parts and characteristics
 {
  absBrakes = true;
  airbag = true;
  mileage = 0;
 }
 
 public Car(string model, string color, int finalMph) //
 {
  this.model = model;
  this.color = color;
  this.finalMph = finalMph;
 }
}

//Main class

class Program
{
 static void Main(string[] args)
 {
  Car c1 = new Car();
  Car c2 = new Car();
  Car c3 = new Car();
  
  c1.Status();
  c2.Status();
  c3.Status();
 }
}

 
 
