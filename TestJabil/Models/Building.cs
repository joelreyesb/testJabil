using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestJabil.Models
{
    public class Building
    {
        [Key]
        public int PKBuilding { get; set; }
        [Required]
        public String BuildingName { get; set; }
    }
}