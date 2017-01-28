//Properties (Get, Set) and Constructors Methods

//===========================================================================

/*1 - Get and Set exercise.
A college student want to have access to his status in the college (tuition loan debt, gpa, current semester etc).
However, those informations are secured and can only be requested in the college's office of academic and 
financial services. Using get and set properties, write a program that shows the student informations.
*/

class StudentStatus
{
  public string name = "Joseph";
  private int loanDebt = 50000;
  private float gpa = 3.46f;
  private string currentSemester = "Last";
  
  public int LoanDebt
  {
    get{ return this.loanDebt;}
    set{ this.loanDebt = loanDebt;}
  }
  
  public
