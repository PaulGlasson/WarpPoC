﻿using System;
using System.Data.Common;
using System.Data.Entity;
using Warp.Core.Data;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Infrastructure.General;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Migrations
{
    /// <summary>
    /// Contains DbSet's for ALL the entities, i.e. all the tables in the database, in one context -- one context to rule them all...
    /// </summary>
    public class MigrationsAndTestingContext : ApplicationDbContextBase, IDomainDbContext, IAuthenticationDbContext, ITextResourceDbContext
    {
        public MigrationsAndTestingContext()
            : base(new ApplicationConfig(), new DateTimeProvider())
        {
        }

        internal MigrationsAndTestingContext(IDateTimeProvider dateTimeProvider, DbConnection existingConnection, bool contextOwnsConnection)
            : base(dateTimeProvider, existingConnection, contextOwnsConnection)
        {
        }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Brand> Brands { get; set; }
        public IDbSet<TextResource> TextResources { get; set; }
        public IDbSet<TextResourceIdentifier> TextResourceIdentifiers { get; set; }
        public IDbSet<Language> Languages { get; set; }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries();

            foreach (var entity in entities)
            {
                var entityBase = (EntityBase) entity.Entity;

                // JK: Set Id if not set... undecided if this is a good idea.
                if (entityBase.Id == Guid.Empty)
                {
                    entityBase.Id = Guid.NewGuid();
                }
            }

            return base.SaveChanges();
        }
    }
}