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
    get{ return this.loanDebt;}
    set{ this.loanDebt = loanDebt;}
  }
  
  public float Gpa
  {
    get{ return this.gpa;}
    set{this.gpa = gpa;}
  }
  public string CurrentSemester
  {
    get{ return this.currentSemester;}
    set{ this.currentSemester = currentSemester;}
  }
  
  public void Status()
  {
    Console.WriteLine("Hello, " + name);
    Console.WriteLine("Your debt is: " + this.loanDebt);
    Console.WriteLine("Your GPA is: " + this.gpa);
    Console.WriteLine("You're in the " + this.currentSemester + ".");
  }
  /*
  Or, you can write the method above like this:
  public void Status()
  {
    Console.WriteLine("Hello, " + name);
    Console.WriteLine("Your debt is: " + getLoanDebt());
    Console.WriteLine("Your GPA is: " + getGpa());
    Console.WriteLine("You're in the " + getCurrentSemester() + ".");
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
    ss1.setLoanDebt(50000);
    ss1.setGpa(3.6f);
    ss1.setCurrentSemester("last");
    
    ss1.Status();
    /*
    Instead of the method above, you can use this:
    Console.WriteLine("Hello, " + name + "\nYour student loan is: " + ss1.getStudentLoan() + "Your GPA is: " + ss1.getGpa() + 
    "\nYou're in the " + ss1.getCurrentSemester() + ".");  */  
  }
}
    
    
    
    
    
  
  
  
  
  
  
