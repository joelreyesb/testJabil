using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestJabil.Models
{
    public class SearchPartNumberResult
    {
        public string PartNumber { get; set; }
        public bool Available { get; set; }
        public string Customer { get; set; }
        public string Building { get; set; }
    }
}