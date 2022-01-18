using DatingAppProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppProject.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name = "John Smith",
                    Address = "123 Haywood Drive",
                    Race = "Caucasian",
                    Gender = "Male",
                    Religion = "Christian",
                    DateOfBirth = DateTime.Now,
                    EducationLevel = "College Degree",
                    Occupation = "Military",
                    Contact = 12345678,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                });
        }
    }
}
