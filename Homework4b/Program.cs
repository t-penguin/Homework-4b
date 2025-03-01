// Test the creation of a BankAccount
BankAccount account = new BankAccount("Joseph Collado", 100);
Console.WriteLine("-----Created a new bank account-----");
PrintAccountDetails(account);
Console.WriteLine();

// Test depositing to the bank account
decimal depositAmount = 376.54m;
account.Deposit(depositAmount);
Console.WriteLine($"-----Deposited {depositAmount:C2}-----");
PrintAccountDetails(account);
Console.WriteLine();

// Test withdrawing from the bank account
decimal withdrawAmount = 128.52m;
bool successfulWithdraw = account.Withdraw(withdrawAmount);
Console.WriteLine($"-----Attempted to withdraw {withdrawAmount:C2}-----");
Console.WriteLine($"Success: {successfulWithdraw}");
PrintAccountDetails(account);
Console.WriteLine();

withdrawAmount = 500;
successfulWithdraw = account.Withdraw(withdrawAmount);
Console.WriteLine($"-----Attempted to withdraw {withdrawAmount:C2}-----");
Console.WriteLine($"Success: {successfulWithdraw}");
PrintAccountDetails(account);
Console.WriteLine();

// Prints the account ID, balance, and transaction history
void PrintAccountDetails(BankAccount account)
{
    Console.WriteLine($"Account ID: {account.AccountID}");
    Console.WriteLine($"Account Balance: {account.Balance:C2}");
    Console.Write("Transaction History: ");
    
    List<decimal> transactionHistory = account.Transactions;
    if (transactionHistory.Count == 0)
    {
        Console.WriteLine("N/A");
        return;
    }

    for (int i = 0; i < transactionHistory.Count; i++)
    {
        decimal transaction = transactionHistory[i];
        if (transaction > 0)
            Console.Write($"+{transaction:C2}");
        else
            Console.Write($"-{-transaction:C2}");

        if (i != transactionHistory.Count - 1)
            Console.Write(", ");
        else
            Console.WriteLine();
    }
}