using fundamentals.csharp.dotnet.api.Models;

namespace fundamentals.csharp.dotnet.api.Data;

public interface ITransactionData
{
    void AddTransaction(Transaction transaction);
    List<Transaction> GetAllTransactions();
}