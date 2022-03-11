using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_Project.Models
{
    public class Unit
    {
        public int id { get; set; }
        public string UnitName { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        [ForeignKey("category")]
        public int CategoryId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Category category { get; set; }
    }
}
