using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Sale> Sale { get; set; }

        public Customer()
        {
            Sale = new List<Sale>();
        }
    }
}