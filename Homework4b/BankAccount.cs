/* Joseph Collado

UML
Class: BankAccount

Fields:
- _accountID : string
- _balance : decimal
- _transactions : List<decimal>

Properties:
+ AccountID : string
+ Balance : decimal
+ Transactions : List<decimal>

Methods:
+ BankAccount(customerName : string, initBalance : decimal)
+ Deposit(decimal amount)
+ Withdraw(decimal amount) : bool
*/

public class BankAccount
{
    // Fields
    private string _accountID;
    private decimal _balance;
    private List<decimal> _transactions;

    // Properties
    public string AccountID { get { return _accountID; } }
    public decimal Balance { get { return _balance; }}
    public List<decimal> Transactions { get { return _transactions; } }

    // Constructor
    public BankAccount(string customerName, decimal initBalance)
    {
        Random rand = new Random();
        // Adds a random 3-digit number to the 
        // customer name to account for duplicates
        _accountID = $"{customerName.Replace(" ", "")}{rand.Next(100, 1000)}";
        _balance = initBalance;
        _transactions = new List<decimal>();
    }

    //Methods

    // Adds the specified amount to the balance and records the transaction
    // PRECONDITION: amount > 0
    public void Deposit(decimal amount)
    {
        _balance += amount;
        _transactions.Add(amount);
    }

    // Attempts to withdraw the specified amount from the balance
    // Records the transaction and returns true if the amount to be withdrawn
    // is less than the current balance. Returns false otherwise.
    // PRECONDITION: amount > 0
    public bool Withdraw(decimal amount)
    {
        if (amount > _balance)
            return false;
        
        _balance -= amount;
        _transactions.Add(-amount);
        return true;
    }
}