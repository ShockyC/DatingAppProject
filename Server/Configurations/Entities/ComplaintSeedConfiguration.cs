using DatingAppProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppProject.Server.Configurations.Entities
{
    public class ComplaintSeedConfiguration : IEntityTypeConfiguration<Complaint>
    {
        public void Configure(EntityTypeBuilder<Complaint> builder)
        {
            builder.HasData(
                new Complaint
                {
                    Id = 1,
                    ComplaintTitle = "404 Error",
                    ComplaintType = "Website"
                    ComplaintDescription = "I keep getting 404 Error",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                });
        }
    }
}
