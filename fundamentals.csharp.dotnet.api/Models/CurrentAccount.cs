using fundamentals.csharp.dotnet.api.Enums;

namespace fundamentals.csharp.dotnet.api.Models;

public class CurrentAccount(int id, string accountNumber, string agencyNumber,
                            decimal balance, AccountType accountType, Client client,
                            AccountStatus accountStatus, DateTime createdAt, DateTime closedAt)
{
    public int Id { get; set; } = id;
    public string AccountNumber { get; set; } = accountNumber;
    public string AgencyNumber { get; set; } = agencyNumber;
    public decimal Balance { get; set; } = balance;
    public AccountType AccountType { get; set; } = accountType;
    public Client Client { get; set; } = client;
    public AccountStatus AccountStatus { get; set; } = accountStatus;
    public DateTime CreatedAt { get; set; } = createdAt;
    public DateTime ClosedAt { get; set; } = closedAt;

    public bool IsEnoughBalance(decimal amount)
    {
        return Balance >= amount;
    }

    public bool IsActive(CurrentAccount currentAccount)
    {
        return currentAccount.AccountStatus.Equals(AccountStatus.Active);
    }

    public void Withdraw(decimal amount, CurrentAccount currentAccount)
    {
        if (!CanProcessTransaction(currentAccount, amount))
        {
            return;
        }
        
        currentAccount.Balance -= amount;
    }

    public void Deposit(decimal amount, CurrentAccount targetAccount, CurrentAccount sourceAccount)
    {
        if (!CanProcessTransaction(sourceAccount, amount) && !IsActive(targetAccount))
        {
            return;
        }
        
        targetAccount.Balance += amount;
        sourceAccount.Balance -= amount;
    }

    private bool CanProcessTransaction(CurrentAccount currentAccount, decimal amount)
    {
        if (!IsActive(currentAccount))
        {
            return false;
        }

        if (!IsEnoughBalance(amount))
        {
            return false;
        }

        if (amount <= 0)
        {
            return false;
        }

        return true;
    }
}
