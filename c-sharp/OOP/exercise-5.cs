//Encapsulation (Interfaces) 

/*
•Encapsulation: It's important to protect your code from the user (or a programmer) and the user from the code.
As a real world example, we can use a AAA battery.The battery has inside it, toxic components(zinc, magnesium oxide, etc) that
are dangerous for the human's health. So, the manufacturer uses a protective case(a CAPSULE) to wrap the battery, avoiding the costumers 
having direct contact with those chemicals and avoiding the costumer damaging the other internal components of the battery.
The battery have the positive and negative terminals to connect with the intended devices.
In OOP, that case (or capsule) can "talk" to the outer world through messages and the "contact channel" is called INTERFACE(on the battery
example, the +/- terminals are the interface).   
 
Below, we have a clear example, a TV remote control:
A Remote Control has it's internal components(battery, circuits, etc) that don't need to be seen nor touched by the user.
So, the manufacturer puts a cover(capsule) with buttons(interface) so the costumer can use the control easily, without damaging or 
be damaged by it.
Using the UML diagram, it become even more clear how the interface works in C#:

------------------------  
|    <<interface>>     |                                                    
|     Controller       | Interface's name                                   
------------------------                                                     
------------------------                                                     
 + TurnOn()               Abstract methods                                               
 + TurnOff()                                                                  
 + OpenMenu()                                                                    
 + CloseMenu()                                                                 
 + VolumeUp()
 + VolumeDown()
 + MuteOn()
 + MuteOff()
 + Play()
 + Pause()
------------------------
An interface doesn't have attributes only abstract methods.
Abstract methods: do not are "developed" inside the interface, but inside the class that it will be implemented.
 the interface just indicates what methods it will have.

/\(class RemoteControl implements)/\
------------------------
|     RemoteControl    | Class's name
------------------------
-volume                  Attributes
-ligado
-tocando
------------------------
 +TurnOn()               The interface methods are implemented here                                                 
 +TurnOff()                                                                  
 +OpenMenu()                                                                    
 +CloseMenu()                                                                 
 +VolumeUp()
 +VolumeDown()
 +MuteOn()
 +MuteOff()
 +Play()
 +Pause()
 -get/set Volume()     Properties
 -get/set Ligado()
 -get/set Tocando()
 ----------------------

•Interface syntax: 
 interface I<<name>>
 {
  <<return type>><<Abstract Method's Name>>();
  //properties and etc
  
 }
 
 class <<class name>> : <<interface's name>>
 {
  //Attributes
  //Method's implementation
  //Properties and constructor
 }

*/
//==========================================================

//Making a C# program using the remote control example above.




