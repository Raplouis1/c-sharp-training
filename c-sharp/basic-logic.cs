//Basic programming logic with C#.

//--------------------------------------------------------

//1-Make a program that gets two grades and their respective weights and, then, calculates the Weighted Average of those two grades.

static void Main(string[] args)
{
  double gradeA; //Example: gradeA = 6
  double gradeB; //Example: gradeB = 8
  int weightGradeA; //Example: weightGradeA = 1
  int weightGradeB; //Example: weightGradeB = 2
  
  Console.WriteLine("Write the first grade:");
  gradeA = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Write the first grade's weight:");
  weightGradeA = Convert.ToInt32(Console.ReadLine());
  
  Console.WriteLine("Write the second grade:");
  gradeB = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Write the second grade's weight:");
  weightGradeB = Convert.ToInt32(Console.ReadLine());
  
  // Example: gradeA = 6 / gradeB = 8 / weightGradeA = 1 / weightGradeB = 2                         
  
  double weightedAverage = ((gradeA * weightGradeA) + (gradeB * weigthGradeB)) / 2;
  //weightedAverage = ( (6 * 1) + (8 * 2) ) / 2 => (6+16) / 2 =>  22 / 2 = 11
  
  Console.WriteLine("Your weighted average is:");  
  Console.WriteLine(weightedAverage); //11
  
}
