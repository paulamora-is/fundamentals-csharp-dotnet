using fundamentals.csharp.dotnet.api.Models;

namespace fundamentals.csharp.dotnet.api.Data;

public interface IClientData
{
    List<Client> GetAllClients();
    Client GetClientById(int id);
    void AddClient(Client client);
    void UpdateClient(Client client);
    void RemoveClient(int id);
}