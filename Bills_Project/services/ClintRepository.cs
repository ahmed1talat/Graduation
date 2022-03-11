using Bills_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bills_Project.services
{
    public class ClintRepository : IClintRepository
    {
        DBEntity context = new DBEntity();
        public List<Client> GetAll()
        {
            List<Client> ClientList = context.clients.ToList();
            return ClientList;
        }
        public Client GetByName(string Name)
        {
            Client client = context.clients.FirstOrDefault(c => c.ClientName == Name);
            return client;
        }
        public Client GetByID(int id)
        {
            Client client = context.clients.FirstOrDefault(c => c.Id == id);
            return client;
        }
        public int Insert(Client client)
        {
           
            context.clients.Add(client);
            int rows = context.SaveChanges();
            return rows;
        }
        public int Delete(int id)
        {
            Client client = context.clients.FirstOrDefault(c => c.Id == id);
            context.clients.Remove(client);
            int rows = context.SaveChanges();
            return rows;

        }
    }
}
