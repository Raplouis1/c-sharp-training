// Programming logic training with C# - Flow control - switch-case

//-----------------------------------------------------------------------

char operation;
float a;
float b;
float result;            

Console.WriteLine("Write 2 numbers:");
Console.WriteLine("Write the first number:");
a = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Write the second number:");
b = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Now, choose one of the four basic math operations(addition (+), subtraction (-), multiplication (*) or division (/) ).Type ");
Console.WriteLine("Use one of the above symbols(+ , - , * or /)");
operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
  case '+':
     result = a + b;
     Console.WriteLine(result);
     break;
  case '-':
     result = a - b;
     Console.WriteLine(result);
     break;
  case '*':
     result = a * b;
     Console.WriteLine(result);
     break;
  case '/':
     result = a / b;
     Console.WriteLine(result);
     break;
  default :
     Console.WriteLine("Wrong key.Type it again.");
     break;
}

//-----------------------------------------------------------------------

