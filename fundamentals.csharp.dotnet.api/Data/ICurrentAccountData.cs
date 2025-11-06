using fundamentals.csharp.dotnet.api.Models;

namespace fundamentals.csharp.dotnet.api.Data;

public interface ICurrentAccountData
{
    public List<CurrentAccount> GetAllCurrentAccounts();
    public CurrentAccount GetCurrentAccountById(int id);
    public void AddCurrentAccount(CurrentAccount currentAccount);
    public void UpdateCurrentAccount(CurrentAccount currentAccount);
    public void RemoveCurrentAccount(int id);
}