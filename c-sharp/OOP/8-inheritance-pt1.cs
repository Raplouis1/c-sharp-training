/*
•Inheritance: allows a new class to receive the characteristics* (inherit) from an class that already exists.
 -Example: A son that has the eyes of his mother.
*The characteristics can be the attributes and the methods.

-Example 2:
 -People in a school: a student, a professor and a secretary (Classes).
 
  •Student:
   name
   age
   sex 
   enrolled
   course
   Birthday()
   DropOutCourse()
   
  •Professor:
   name
   age
   sex
   speciality
   salary
   Birthday()
   SalaryRaise()
   
  •Secretary:
   name
   age
   sex
   department
   working
   Birthday()
   StopWorking()   
   
  -Note that the three classes has common characteristics (name, age, sex and Birthday() ).So, through that, we can
   know that they have a "mother" class called Person that owns all that characteristics that they inherit:
 
   •Person:
    name
    age
    sex
    Birthday()
   


*/
//=================================================================

//Class Person
    class Person
    {
        private string name;
        private int age;
        private string sex;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public void Birthday()
        {
            age += 1;
        }
    }

//Class Student
    class Student : Person //Student implements Person, so, Student will receive all attributes and methods of Person
    {
        private bool enrolled; 
        private string course;
         
        public bool Enrolled
        {
            get { return enrolled; }
            set { enrolled = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public void DropOutCourse() 
        {
            enrolled = false;
        }                    
            
     }

//Class Professor
    class Professor : Person
    {
        private string specialty;
        private float salary;

        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public  void SalaryRaise()
        {
            salary += salary * 0.10f;
        }
    }
    
//Class Secretary
    class Secretary : Person
    {
        private string department;
        private bool working;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public bool Working
        {
            get { return working; }
            set { working = value; }
        }
        
        public void StopWorking()
        {
            working = false;
        }
        
    }
    
//Main Class
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Student p2 = new Student();
            Professor p3 = new Professor();
            Secretary p4 = new Secretary();

            p1.Name = "Peter";
            p2.Name = "Logan";
            p3.Name = "John";
            p4.Name = "Mary";

            p2.Course = "Computer Science";
            p3.Salary = 5000.0f;
            p4.Department = "Students Service";   
            
        }
    }
