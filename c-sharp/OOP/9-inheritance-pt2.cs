/*
•UML Inheritance Tree:


-------------------------------------------------------->>> Specialization: "travel" from the top to the bottom  of thre uml tree
      |--AC <------ ACA
 A <-----AA <------ AAA
(Root)|--AB <------ ABA <----- ABAA 
                           |-- ABAB
                               (Leaves(Leaf))
<<<-------------------------------------------------------- Generalization: "travel" from the bottom to the top  of thre uml tree                         

Note: In the example above, the Root of the tree (A) is a class that doesn't have any mother class (or superclass) above it
and the Leaves(leaf)(ABAA and ABAB) are the classes that dont't have children classes(or sub classes)

Note:
-More you travel through the tree, more the classes become SPECIALIZED i.e. more detailed the classes become:
 -Example: Person <----- Student <----- UndergraduateStudent
  -A Person has: name, age, sex and Birthday();
  -A Student has all the characteristics from Person plus studentNumber, course and payTuition();
  -A UndergraduateStudent have all the characteristics from Person + Student plus internship, loan, payLoan(); and gotInternship();


*/
//============================================================================
