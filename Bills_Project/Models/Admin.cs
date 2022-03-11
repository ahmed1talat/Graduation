using System.Collections.Generic;

namespace Bills_Project.Models
{
    public class Admin
    {
        public Admin()
        {

            Clients = new HashSet<Client>();
            Categories = new HashSet<Category>();
            sales = new HashSet<Sales>();
            Types = new HashSet<Type>();
            Units = new HashSet<Unit>();
            companyies = new HashSet<Company>();

        }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Sales> sales { get; set; }
        public virtual ICollection<Type> Types { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
        public virtual ICollection<Company> companyies { get; set; }
    }
}
