
//TestWithoutSRP();
TestWithSRP();
Console.ReadKey();

static void TestWithoutSRP()
{
    var account =
        new SOLID.SRP.Before.Account("Momen", "momen@example.com", 10000m);
    account.MakeTransaction(500);
    account.MakeTransaction(-11000);
}

static void TestWithSRP()
{
    var account =
        new SOLID.SRP.After.Account("Momen", "momen@example.com", 10000m);

    var accountService = new SOLID.SRP.After.AccountService();
    accountService.Deposit(account, 500);
    accountService.WithDraw(account, 11000);
}
