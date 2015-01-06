﻿using System;

namespace Warp.Core.Data
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}