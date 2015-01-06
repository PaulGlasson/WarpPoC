﻿using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Clients;

namespace Warp.Testing.Unit.Data.Queries.Clients
{
    [Subject("Check Client Exists For Code Query")]
    public class CheckClientExistsForCodeQueryHandlerTests
    {
        public class When_querying_for_a_client_that_exists : WithSubject<CheckClientExistsForCodeQueryHandler>
        {
            const int CustomerId = 123;
            const string Code = "asd";
            static bool _result;

            Establish that = () =>
                // Mock the Clients DbSet.
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Clients)
                    .Return(new InMemoryDbSet<Client>(true)
                    {
                        new Client {Code = "qwe", Customer = new Customer{ Id = 111 }},
                        new Client {Code = "asd", Customer = new Customer{ Id = CustomerId }},
                        new Client {Code = "zxc", Customer = new Customer{ Id = 312 }}
                    });

            Because of = () => _result = Subject.Execute(new CheckClientExistsForCodeQuery { CustomerId = CustomerId, ClientCode = Code });

            It should_return_true = () =>
                _result.ShouldBeTrue();
        }

        public class When_querying_for_a_client_that_does_not_exist : WithSubject<CheckClientExistsForCodeQueryHandler>
        {
            const int CustomerId = 123;
            const string Code = "asd";
            static bool _result;

            Establish that = () =>
                // Mock the Clients DbSet.
                The<IDomainDbContext>()
                    .WhenToldTo(d => d.Clients)
                    .Return(new InMemoryDbSet<Client>(true)
                    {
                        new Client {Code = "qwe", Customer = new Customer{ Id = 111 }},
                        new Client {Code = "asd", Customer = new Customer{ Id = 222 }},
                        new Client {Code = "zxc", Customer = new Customer{ Id = 312 }}
                    });

            Because of = () => _result = Subject.Execute(new CheckClientExistsForCodeQuery { CustomerId = CustomerId, ClientCode = Code });

            It should_return_true = () =>
                _result.ShouldBeFalse();
        }
    }
}