using System;
using Microsoft.AspNet.Identity;
using Warp.Core.Authentication;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Infrastructure.General;
using Warp.Data.Context;
using Warp.Data.Identity;

namespace Warp.IoC.Factories
{
    internal sealed class UserManagerFactory
    {
        private readonly IAuthenticationDbContext _context;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IApplicationConfig _applicationConfig;

        public UserManagerFactory(IAuthenticationDbContext context, IDateTimeProvider dateTimeProvider, IPasswordHasher passwordHasher, IApplicationConfig applicationConfig)
        {
            _context = context;
            _dateTimeProvider = dateTimeProvider;
            _passwordHasher = passwordHasher;
            _applicationConfig = applicationConfig;
        }

        public UserManager<ApplicationUser, Guid> Build()
        {
            return new UserManager<ApplicationUser, Guid>(new ApplicationUserStore(_context, _dateTimeProvider, _applicationConfig))
            {
                DefaultAccountLockoutTimeSpan = _applicationConfig.DefaultAccountLockoutTimeSpan,
                MaxFailedAccessAttemptsBeforeLockout = _applicationConfig.MaxFailedAccessAttemptsBeforeLockout,
                PasswordHasher = _passwordHasher
            };
        }
    }
}