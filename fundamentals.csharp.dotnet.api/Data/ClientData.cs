using fundamentals.csharp.dotnet.api.Models;

namespace fundamentals.csharp.dotnet.api.Data;

public class ClientData : IClientData
{
    private static readonly List<Client> _clients = new()
    {
        new Client(1, "Maria Silva", "123.456.789-00", new DateTime(1990, 1, 1), "mariasilva@email.com",
                    new Address("Rua A", "100", "Casa A", "Bairro A", "São Paulo", "SP", "01000-000"), new Phone("+55", "11", "91234-5678")),
        new Client(2, "João Souza", "987.654.321-00", new DateTime(1985, 5, 15), "joaosouza@email.com",
                    new Address("Avenida B", "200", "Casa B", "Bairro B", "Rio de Janeiro", "RJ", "20000-000"), new Phone("+55", "21", "99876-5432")),
        new Client(3, "Ana Pereira", "456.789.123-00", new DateTime(1995, 10, 30), "anapereira@email.com",
                    new Address("Travessa C", "300", "Casa C", "Bairro C", "Belo Horizonte", "MG", "30000-000"), new Phone("+55", "31", "98765-4321")),
        new Client(4, "Carlos Oliveira", "321.654.987-00", new DateTime(1980, 3, 20), "carlosoliveira@email.com", new Address(
                    "Praça E", "500", "Casa D", "Bairro D", "Salvador", "BA", "50000-000"),
                    new Phone("+55", "71", "97654-3210")),
    };

    public List<Client> GetAllClients()
    {
        return _clients;
    }

    public Client GetClientById(int id)
    {
        return _clients.FirstOrDefault(c => c.Id == id);
    }

    public void AddClient(Client client)
    {
        _clients.Add(client);
    }

    public void UpdateClient(Client client)
    {
        Client existingClient = GetClientById(client.Id);
        if (existingClient is null)
            return;

        existingClient.Email = client.Email;
        existingClient.Address = client.Address;
        existingClient.Phone = client.Phone;
    }

    public void RemoveClient(int id)
    {
        Client existingClient = GetClientById(id);
        if (existingClient is null)
            return;
        
        _clients.Remove(existingClient);
    }
}