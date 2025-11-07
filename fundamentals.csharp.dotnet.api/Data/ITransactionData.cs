using System.Transactions;

namespace fundamentals.csharp.dotnet.api.Data;

public interface ITransactionData
{
    void AddTransaction(Transaction transaction);
    List<Transaction> GetAllTransactions();
}