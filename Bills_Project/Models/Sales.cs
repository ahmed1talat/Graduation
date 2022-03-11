using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_Project.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime BillsDate { get; set; }
        public int BuyingQuantity { get; set; }
        public int Discount { get; set; } 
        public string EmployeeName { get; set; }
        
        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        [ForeignKey("client")]
        public int ClientId { get; set; }
        [ForeignKey("category")]
        public int CategoryId { get; set; }  
        

        public virtual Admin Admin { get; set; }
        public virtual Client client { get; set; }
        public virtual Category category { get; set; }
    }
}
