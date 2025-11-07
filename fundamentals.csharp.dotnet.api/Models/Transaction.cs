using fundamentals.csharp.dotnet.api.Enums;

namespace fundamentals.csharp.dotnet.api.Models;

public record Transaction
{
    public Transaction(int id, TransactionType transactionType, CurrentAccount originalCurrentAccount, CurrentAccount targetCurrentAccount, decimal amount, DateTime dateTransaction)
    {
        Id = id;
        TransactionType = transactionType;
        OriginalCurrentAccount = originalCurrentAccount;
        TargetCurrentAccount = targetCurrentAccount;
        Amount = amount;
        DateTransaction = dateTransaction;
    }

    public int Id { get; init; }
    public TransactionType TransactionType { get; init; }
    public CurrentAccount OriginalCurrentAccount { get; init; }
    public CurrentAccount TargetCurrentAccount { get; init; }
    public decimal Amount { get; init; }
    public DateTime DateTransaction { get; init; }
}