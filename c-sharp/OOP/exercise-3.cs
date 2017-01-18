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
*/

//=======================================================================
//=======================================================================

//Using the example above, create a program in C# using access modifiers(public, private and protected):

class Pen {
 public model;
 public color;
 private tipSize;
 protected remainingInk;
 protected lid;
 
 
 
 

