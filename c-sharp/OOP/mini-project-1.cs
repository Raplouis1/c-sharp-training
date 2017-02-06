//Exercise using all OOP concepts up to "exercise-4" file.

//======================================================

/*
Two people (Mary and John) want to put some money in their bank account.John opened a savings account to deposit his 300U$ and Mary opened 
a checking account to deposit 500U$ and then, withdrew 100$ to buy a pair of shoes.
Each account have the following attributes and methods:

BankAccount //Class name

//Attributes (+public / # protected / - private)
+ account number
# type(checkings/savings)
- client name
- balance
- status(true->account is open / false->account is closed)

//Methods (in this example, all methods are public)
• open account (turns 'status' into true / if chose checkings += 50 / if chose savings +=150)
• close account (turns 'status' into false / can't have money in the account or have debits)
• deposit (status must be true)
• withdraw (status must be true / balance must be >= value )
• pay monthly fee (checkings=12 / savings=20)
• constructor new account (status = false, balance = 0)
• getters/setters

So, write a program to create and manage the clients' accounts.

//======================================================








