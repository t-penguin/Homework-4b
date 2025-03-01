// Test the creation of a BankAccount
BankAccount account = new BankAccount("Joseph Collado", 100);
Console.WriteLine("-----Created a new bank account-----");
PrintAccountDetails(account);
Console.WriteLine();

// Test depositing to the bank account
decimal depositAmount = 376.54m;
account.Deposit(depositAmount);
Console.WriteLine($"-----Deposited {depositAmount}-----");
PrintAccountDetails(account);

// Prints the account ID, balance, and transaction history
void PrintAccountDetails(BankAccount account)
{
    Console.WriteLine($"Account ID: {account.AccountID}");
    Console.WriteLine($"Account Balance: {account.Balance}");
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
            Console.Write($"+{transaction}");
        else
            Console.Write(transaction);

        if (i != transactionHistory.Count - 1)
            Console.Write(", ");
        else
            Console.WriteLine();
    }
}