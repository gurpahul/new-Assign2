using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public Customer Customer { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string EmployeeToApproveId { get; set; }
        public Employee EmployeeToApprove { get; set; }
        public ICollection<Product> Products { get; set; }
        public Sale()
        {
            Products = new List<Product>();
        }
    }
}