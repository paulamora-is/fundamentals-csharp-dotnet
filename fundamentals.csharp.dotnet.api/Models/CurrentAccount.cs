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

    public void Deposit(decimal amount, CurrentAccount targetAccount, CurrentAccount sourceAccount)
    {
        if (!IsActive(targetAccount))
        {
            throw new InvalidOperationException("Cannot deposit to an inactive account.");
        }

        if(!IsEnoughBalance(amount))
        {
            throw new InvalidOperationException("Insufficient balance for the deposit.");
        }

        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        targetAccount.Balance += amount;
        sourceAccount.Balance -= amount;
    }
}
