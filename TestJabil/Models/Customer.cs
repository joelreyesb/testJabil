using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestJabil.Models
{
    public class Customer
    {
        [Key]
        public int PKCustomer { get; set; }
        [Required]
        public String customer { get; set; }
        [StringLength(5)]
        public String Prefix { get; set; }

        public int FKBuilding { get; set; }

        public virtual Building building { get; set; }
    }
}