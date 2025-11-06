namespace fundamentals.csharp.dotnet.api.Models;

public record Client
{
    public Client(int id, string name, string document, DateTime birthDate, string email,
                    Address address, Phone phone)
    {
        Id = id;
        Name = name;
        Document = document;
        BirthDate = birthDate;
        Email = email;
        Address = address;
        Phone = phone;
    }

    public int Id { get; init; }
    public string Name { get; init; }
    public string Document { get; init; }
    public DateTime BirthDate { get; init; }
    public string Email { get; set; }
    public Address Address  { get;  set; }
    public Phone Phone { get; set; }
}