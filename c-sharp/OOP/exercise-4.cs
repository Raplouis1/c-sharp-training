//Properties (Get, Set) and Constructors Methods

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
}  
