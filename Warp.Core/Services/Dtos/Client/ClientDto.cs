﻿using System;
using Warp.Core.Enum;
using Warp.Core.Services.Dtos.Users;

namespace Warp.Core.Services.Dtos.Client
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ClientStatus Status { get; set; }
        public string Code { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? DateValidFrom { get; set; }
        public UserDto AccountManager { get; set; }
    }
}