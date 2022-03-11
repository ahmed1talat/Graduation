using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_Project.Models
{
    public class Type            //in species screen
    {
        public Type()
        {
            Categories = new HashSet<Category>();
        }
        public int id { get; set; }
        
        public string TypeName { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
