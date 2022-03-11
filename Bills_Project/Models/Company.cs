using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_Project.Models
{
    public class Company
    {
        public Company()
        {
            Categories = new HashSet<Category>();
            types = new HashSet<Type>();
        }
        public int id { get; set; }
        public string CompanyName { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Type> types { get; set; }
    }
}
