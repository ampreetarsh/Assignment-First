using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentFirst.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public Product() {
            Sales = new List<Sale>();
        }
    }
}