namespace fundamentals.csharp.dotnet.api.Models;

public record Client
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Document { get; init; }
    public DateTime BirthDate { get; init; }
    public string Email { get; set; }
    public Address Address  { get;  set; }
    public Phone Phone { get; set; }
}