﻿using System;
using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Testing.Unit.Data.Util;

namespace Warp.Testing.Unit.Data.Data
{
    public class LanguageTestDataFactory : ITestDataFactory<Language>
    {
        public IEnumerable<Language> Build()
        {
            return new[]
            {
                new Language {Id = Guid.NewGuid(), InvariantCulture = "en", Locale = "GB", Name = "English"},
                new Language {Id = Guid.NewGuid(), InvariantCulture = "fr", Locale = "FR", Name = "French"},
                new Language {Id = Guid.NewGuid(), InvariantCulture = "nl", Locale = "NL", Name = "Dutch"},
                new Language {Id = Guid.NewGuid(), InvariantCulture = "de", Locale = "DE", Name = "German"},
                new Language {Id = Guid.NewGuid(), InvariantCulture = "oo", Locale = "AR", Name = "Pirate"}
            };
        }
    }
}
