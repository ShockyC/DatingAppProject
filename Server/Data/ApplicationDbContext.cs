using DatingAppProject.Server.Configurations.Entities;
using DatingAppProject.Server.Models;
using DatingAppProject.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppProject.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ReviewOnCustomer> ReviewOnCustomers { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<CustomerPreference> CustomerPreferences { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new StaffSeedConfiguration());
            builder.ApplyConfiguration(new CustomerSeedConfiguration());
            builder.ApplyConfiguration(new ComplaintSeedConfiguration());
        }
    }
}
