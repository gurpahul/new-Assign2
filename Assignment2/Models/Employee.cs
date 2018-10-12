using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }
        public ICollection<Sale> Sale { get; set; }


        public Employee()
        {
            Sale = new List<Sale>();
        }
    }
}