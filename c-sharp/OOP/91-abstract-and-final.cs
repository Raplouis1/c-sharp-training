/*
•Abstract and final:
 -We can have classes and methods abstract or final
 So:
 -Abstract class: Can't be instanced i.e. can't make objects.It can only serve as superclass for subclasses. 
 -Abstract method: Declared but it isn't implemented on the superclass(Example: the interface methods).
 -Final class: Can't be inherited by other classes.It is a leaf in the uml tree.
 -Final method: Can't be overrided by subclasses' method.It can only be inherited.
 
 Notes:
 
 -Methods in C# are by default "final".So, if you want the subclasses to override it, you need to put the word "virtual" in the
  base class method.
  -Example:
   public class Example
   {
    ...
    public virtual void Ex()
    {
      ...
    }
   }
   -------------------
   public class ExampleChild : Example
   {
    ...
    public override void Ex()
    {
     ...
    }
   }
   
 
*/

//==================================================================================================
