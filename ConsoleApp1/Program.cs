using ConsoleApp1.src.OopPriciples.Encapsulation;

BankAccount bankAccount = new BankAccount(100);

System.Console.WriteLine("Current Balance: "+bankAccount.GetBalance());


bankAccount.Deposite(150);
System.Console.WriteLine("Current Balance: "+bankAccount.GetBalance());

bankAccount.Withdraw(50);
System.Console.WriteLine("Current Balance: "+bankAccount.GetBalance());
