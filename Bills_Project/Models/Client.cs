using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_Project.Models
{
    public class Client
    {
        public Client()
        {
            sales = new List<Sales>();
        }
        
        public int Id { get; set; }
        [Required(ErrorMessage =" CLIENT NAME IS Required")]
        [Remote(action: "UniqueClintName",controller:"Admin",ErrorMessage ="CLINT NAME has already existed before")]
        public string ClientName { get; set; }
        [Required(ErrorMessage ="PHONE IS Rquired")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{14})$", ErrorMessage = "Please Enter Valid Mobile Number.")]
        public string Phone { get; set; }
        public string Number { get; set; }
        [Required(ErrorMessage ="Address is Required")]
        public string Address { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual ICollection<Sales> sales { get; set; }
    }
}

