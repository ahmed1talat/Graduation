using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_Project.Models
{
    public class Category
    {
        public Category()
        {
            sales = new HashSet<Sales>();
            units = new HashSet<Unit>();
        }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TypeName { get; set; }               
        public string CategoryName { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal BuyingPrice { get; set; }
        public int BaseQuantity { get; set; }     
        public string Notes { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        [ForeignKey("Type")]
        public int TypeId { get; set; }
        [ForeignKey("CompanyData")]
        public int CompanyId { get; set; }
        
        public virtual Admin Admin { get; set; }
        public virtual Type Type { get; set; }
        public virtual Company company { get; set; }
        
        public virtual ICollection<Sales> sales { get; set; }
        public virtual ICollection<Unit> units { get; set; }

    }
}
