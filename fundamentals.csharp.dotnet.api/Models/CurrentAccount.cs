using fundamentals.csharp.dotnet.api.Enums;

namespace fundamentals.csharp.dotnet.api.Models;

public class CurrentAccount
{
    public Guid Id { get; set; }
    public string AccountNumber { get; set; }
    public string AgencyNumber { get; set; }
    public decimal Balance { get; set; }
    public AccountType AccountType { get; set; }
    public Client Client { get; set; }
    public AccountStatus AccountStatus { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ClosedAt { get; set; }
}
