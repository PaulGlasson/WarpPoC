﻿using System;
using System.Collections.Generic;
using System.Linq;
using Warp.Data.Entities;
using Warp.Testing.Unit.Data.Util;

namespace Warp.Testing.Unit.Data.Data
{
    public class TextResourceTestDataFactory : ITestDataFactory<TextResource>
    {
        protected Guid tr1Id { get; set; }
        protected Guid tr2Id { get; set; }
        protected Guid tr3Id { get; set; }
        protected Guid tr4Id { get; set; }
        protected Guid tr5Id { get; set; }
        protected Guid tr6Id { get; set; }
        protected Guid tr7Id { get; set; }
        protected Guid tr8Id { get; set; }
        protected Guid tr9Id { get; set; }
        protected Guid tr10Id { get; set; }
        protected Guid tr11Id { get; set; }
        protected Guid tr12Id { get; set; }

        public TextResourceTestDataFactory()
        {
            tr1Id = Guid.NewGuid();
            tr2Id = Guid.NewGuid();
            tr3Id = Guid.NewGuid();
            tr4Id = Guid.NewGuid();
            tr5Id = Guid.NewGuid();
            tr6Id = Guid.NewGuid();
            tr7Id = Guid.NewGuid();
            tr8Id = Guid.NewGuid();
            tr9Id = Guid.NewGuid();
            tr10Id = Guid.NewGuid();
            tr11Id = Guid.NewGuid();
            tr12Id = Guid.NewGuid();
        }

        public IEnumerable<TextResource> Build()
        {
            var languages = new LanguageTestDataFactory().Build();

            return new[]
            {
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Welcome!",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Log In",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Password",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Username",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "Remember me for 2 weeks",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                },
                new TextResource
                {
                    Id = Guid.NewGuid(),
                    ResourceString = "E-mail or TMDC Id",
                    TextResourceIdentifier = new TextResourceIdentifier {Id = Guid.NewGuid()},
                    Language = languages.Single(l => l.InvariantCulture == "en"),
                    Client = new Client {Id = Guid.NewGuid()}
                }
            };
        }
    }
}
