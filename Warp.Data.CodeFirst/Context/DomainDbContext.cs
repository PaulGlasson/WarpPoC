using System.Data.Entity;
using Warp.Core.Infrastructure;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Util;
using Warp.Data.Entities;

namespace Warp.Data.Context
{
    public sealed class DomainDbContext : ApplicationDbContextBase, IDomainDbContext
    {
        public DomainDbContext(IApplicationConfig applicationConfig, IDateTimeProvider dateTimeProvider)
            : base(applicationConfig, dateTimeProvider)
        {
        }

        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Brand> Brands { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        //public IDbSet<ClientAccountManager> ClientAccountManagers { get; set; }
    }
}