using DatingAppProject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppProject.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Complaint> Complaints { get; }
    }
}
