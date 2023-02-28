
//Before LSP
//var account = new SOLID.LSP.Before.FixedDepositAccount("Issam", 10_000);
//account.Withdraw(1000);

//After LSP
//var account = new SOLID.LSP.After.FixedDepositAccount("Issam", 10_000);
//account.Withdraw(1000); // won't work

var account = new SOLID.LSP.After.CheckingAccount("Moamen", 10_000);
account.Withdraw(10000);


Console.ReadLine();
