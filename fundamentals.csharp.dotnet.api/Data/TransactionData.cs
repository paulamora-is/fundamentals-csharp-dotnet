using fundamentals.csharp.dotnet.api.Enums;
using fundamentals.csharp.dotnet.api.Models;

namespace fundamentals.csharp.dotnet.api.Data;

public class TransactionData : ITransactionData
{
    private static readonly ICurrentAccountData _currentAccountData;
    private static readonly List<Transaction> _transactions = new()
   {
        new Transaction(1, TransactionType.Deposit, GetCurrentAccountData(1), GetCurrentAccountData(2), 500, new DateTime(2024, 1, 15)),
        new Transaction(2, TransactionType.Withdrawal, GetCurrentAccountData(2), null, 200, new DateTime(2024, 2, 10)),
        new Transaction(3, TransactionType.Transfer, GetCurrentAccountData(3), GetCurrentAccountData(4), 150, new DateTime(2024, 3, 5)),
        new Transaction(4, TransactionType.Investment, GetCurrentAccountData(3), null, 800, new DateTime(2024, 4, 20)),
        new Transaction(5, TransactionType.BillPayment, GetCurrentAccountData(4), null, 300, new DateTime(2024, 5, 25)),
        new Transaction(6, TransactionType.Pix, GetCurrentAccountData(1), GetCurrentAccountData(3), 450, new DateTime(2024, 6, 12)),
        new Transaction(7, TransactionType.FeeCollection, GetCurrentAccountData(2), null, 100, new DateTime(2024, 7, 18)),
        new Transaction(8, TransactionType.Redemption, GetCurrentAccountData(4), null, 600, new DateTime(2024, 8, 30)),
        new Transaction(9, TransactionType.Ted, GetCurrentAccountData(1), GetCurrentAccountData(4), 700, new DateTime(2024, 9, 14)),
        new Transaction(10, TransactionType.Doc, GetCurrentAccountData(2), GetCurrentAccountData(3), 250, new DateTime(2024, 10, 22)),
        new Transaction(11, TransactionType.Deposit, GetCurrentAccountData(3), GetCurrentAccountData(1), 400, new DateTime(2024, 11, 8)),
        new Transaction(12, TransactionType.Withdrawal, GetCurrentAccountData(4), null, 350, new DateTime(2024, 12, 3))
    };

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
    }

    public List<Transaction> GetAllTransactions()
    {
        return _transactions;
    }
    
    public Transaction GetTransactionById(int id)
    {
        return _transactions.FirstOrDefault(t => t.Id == id);
    }

   private static CurrentAccount GetCurrentAccountData(int id)
   {
       return _currentAccountData.GetCurrentAccountById(id);
   }
}