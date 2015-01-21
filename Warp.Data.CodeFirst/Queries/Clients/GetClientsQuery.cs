using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Clients
{
    public sealed class GetClientsQuery : IQuery<IEnumerable<Client>>
    {
        public string Query { get; set; }

        public Guid CustomerId { get; set; }
    }

    public class GetClientsQueryValidator : AbstractValidator<GetClientsQuery>
    {
        public GetClientsQueryValidator()
        {
            RuleFor(q => q.CustomerId).NotEmptyGuid();
        }
    }

    public sealed class GetClientsQueryHandler : IQueryHandler<GetClientsQuery, IEnumerable<Client>>
    {
        private readonly IDomainDbContext _context;

        public GetClientsQueryHandler(IDomainDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> Handle(GetClientsQuery query)
        {
            var result = _context.Clients
                .Where(c => c.Customer.Id == query.CustomerId);

            if (!String.IsNullOrWhiteSpace(query.Query))
            {
                result = result.Where(u => u.Name.Contains(query.Query) || u.Code.Contains(query.Query));
            }

            return result;
        }
    }
}