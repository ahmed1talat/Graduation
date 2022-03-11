using Bills_Project.Models;
using System.Collections.Generic;

namespace Bills_Project.services
{
    public interface IClintRepository
    {
        int Delete(int id);
        List<Client> GetAll();
        Client GetByID(int id);
        Client GetByName(string Name);
        int Insert(Client client);
    }
}