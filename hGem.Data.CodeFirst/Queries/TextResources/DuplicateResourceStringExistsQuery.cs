﻿using System.ComponentModel.DataAnnotations;
using System.Linq;
using hGem.Core.Cqrs;
using hGem.Data.Context;

namespace hGem.Data.Queries.TextResources
{
    public class DuplicateResourceStringExistsQuery : IQuery<bool>
    {
        [Required]
        public string ResourceString { get; set; }
    }

    public class DuplicateResourceStringExistsQueryHandler : IQueryHandler<DuplicateResourceStringExistsQuery, bool>
    {
        private readonly ITextResourceDbContext _dbContext;

        public DuplicateResourceStringExistsQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Handle(DuplicateResourceStringExistsQuery query)
        {
            return _dbContext.TextResources
                .Any(tr => tr.ResourceString == query.ResourceString);
        }
    }
}