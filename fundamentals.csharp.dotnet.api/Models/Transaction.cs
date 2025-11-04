using fundamentals.csharp.dotnet.api.Enums;

namespace fundamentals.csharp.dotnet.api.Models;

public record Transaction
{
    public Guid Id { get; init; }
    public TransactionType TransactionType { get; init; }
    public CurrentAccount OriginalCurrentAccount { get; init; }
    public CurrentAccount TargetCurrentAccount { get; init; }
    public decimal Amount { get; init; }
    public DateTime DateTransaction { get; init; }
}