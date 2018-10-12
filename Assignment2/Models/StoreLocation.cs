using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public ICollection<Sale> Sale { get; set; }

        public StoreLocation()
        {
            Sale = new List<Sale>();
        }
    }
}