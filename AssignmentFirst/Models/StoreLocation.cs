﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentFirst.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }

        public StoreLocation()
        {
            Sales = new List<Sale>();
        }
    }
}