using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestJabil.Models
{
    public class PartNumbers
    {
        [Key]
        public int PKPartNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNumberValue { get; set; }

        [ForeignKey("Customer")]
        public int FKCustomer { get; set; }

        public bool Available { get; set; }

        // Propiedad de navegación a la entidad Customer
        public virtual Customer Customer { get; set; }
    }
}