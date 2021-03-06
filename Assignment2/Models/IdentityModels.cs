﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Assignment2.Models
{



    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        public ICollection<Sale> Sales { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<Sale> Employees { get; set; }
        [InverseProperty("EmployeeToApprove")]
        public virtual ICollection<Sale> Employeesthatimproves { get; set; }

        public ApplicationUser()
        {
            Sales = new HashSet<Sale>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Assignment2.Models.Sale> Sales { get; set; }
        public System.Data.Entity.DbSet<Assignment2.Models.Customer> Customers { get; set; }
        public System.Data.Entity.DbSet<Assignment2.Models.Employee> Employees { get; set; }
        public System.Data.Entity.DbSet<Assignment2.Models.Product> Products { get; set; }
        public System.Data.Entity.DbSet<Assignment2.Models.StoreLocation> StoreLocations { get; set; }
    }
}