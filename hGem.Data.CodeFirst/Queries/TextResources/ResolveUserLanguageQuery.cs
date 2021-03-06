﻿using System;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;

namespace hGem.Data.Queries.TextResources
{
    public sealed class ResolveUserLanguageQuery : IQuery<Guid>
    {
        public Guid UserId { get; set; }
    }

    public class ResolveUserLanguageQueryValidator : AbstractValidator<ResolveUserLanguageQuery>
    {
        public ResolveUserLanguageQueryValidator()
        {
            RuleFor(q => q.UserId).NotEmptyGuid();
        }
    }

    public sealed class ResolveUserLanguageQueryHandler : IQueryHandler<ResolveUserLanguageQuery, Guid>
    {
        private readonly ITextResourceDbContext _context;

        public ResolveUserLanguageQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public Guid Handle(ResolveUserLanguageQuery query)
        {
            return _context.Users
                .Where(u => u.Id == query.UserId)
                .Select(u => u.DefaultLanguageId)
                .SingleOrDefault();
        }
    }
}