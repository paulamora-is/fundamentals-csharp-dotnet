using fundamentals.csharp.dotnet.api.Models;
using fundamentals.csharp.dotnet.api.Enums;

namespace fundamentals.csharp.dotnet.api.Data;

public class CurrentAccountData : ICurrentAccountData
{
    private static readonly IClientData _clientData;
    private static readonly List<CurrentAccount> _currentAccounts = new()
    {
        new CurrentAccount(1, "123456-7", "0001",  1000.00m,  AccountType.IndividualCheckingAccount, _clientData.GetClientById(1), AccountStatus.Active, DateTime.Now.AddYears(-1), DateTime.MinValue),
        new CurrentAccount(2, "234567-8", "0001",  2500.50m,  AccountType.SavingsAccount, _clientData.GetClientById(2), AccountStatus.Active, DateTime.Now.AddMonths(-6), DateTime.MinValue),
        new CurrentAccount(3, "345678-9", "0002",     0m,  AccountType.SalaryAccount, _clientData.GetClientById(3), AccountStatus.Inactive, DateTime.Now.AddYears(-2), DateTime.Now.AddMonths(-1)),
        new CurrentAccount(4, "456789-0", "0002",  750.25m,  AccountType.JointAccount, _clientData.GetClientById(4), AccountStatus.Active, DateTime.Now.AddMonths(-3), DateTime.MinValue)
    };

    public List<CurrentAccount> GetAllCurrentAccounts()
    {
        return _currentAccounts;
    }

    public CurrentAccount GetCurrentAccountById(int id)
    {
        return _currentAccounts.FirstOrDefault(ca => ca.Id.Equals(id));
    }

    public void AddCurrentAccount(CurrentAccount currentAccount)
    {
        _currentAccounts.Add(currentAccount);
    }

    public void UpdateCurrentAccount(CurrentAccount currentAccount)
    {
        CurrentAccount existingAccount = GetCurrentAccountById(currentAccount.Id);
        if (existingAccount is null)
            return;

        existingAccount.Balance = currentAccount.Balance;
        existingAccount.AccountStatus = currentAccount.AccountStatus;
        existingAccount.Client = currentAccount.Client;
    }

    public void RemoveCurrentAccount(int id)
    {
        CurrentAccount existingAccount = GetCurrentAccountById(id);
        if (existingAccount is null)
            return;
        
        _currentAccounts.Remove(existingAccount);
    }
}