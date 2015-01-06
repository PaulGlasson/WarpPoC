﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    /// <summary>
    /// Wrapper for SaveTextResourceCommand aggregate
    /// </summary>
    public sealed class SaveNewTextResourceCommand : ICommand
    {
        public int Id { get; internal set; }

        // Required TextResourceIdentifier data
        [Required]
        public string ResourceIdentifierCode { get; set; }

        [Required]
        public bool ClientOverridable { get; set; }

        // Required TextResource data
        [IdRequired]
        public int LanguageId { get; set; }

        // Populated after successful TextResourceIdentifier validation(Here or in Dispatcher?)
        public int ResourceIdentifierId { get; set; }

        [Required]
        public string ResourceString { get; set; }

    }

    public sealed class SaveNewTextResourceCommandHandler : ICommandHandler<SaveNewTextResourceCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public void Execute(SaveNewTextResourceCommand command)
        {
            // Validate ResourceIdentifierCode
                // No. Get Associated TextResource data, populate and return DuplicateTextResourceDto to User(ResourceIdentifier and associated TextResource dto)
                // Yes(No duplicate).
                    // Validate ResourceString
                        // No.(Duplicate). Return duplicate data to User(Aggregized ResourceIdentifierDto and associated TextResourceDto)
                        // Yes.
                            // Invoke SaveNewResourceIdentifierCommand and return ResourceIdentifierId
                            // Invoke SaveNewResourceCommand and return TextResourceDetailsDto to User

            throw new NotImplementedException();
        }
    }
}