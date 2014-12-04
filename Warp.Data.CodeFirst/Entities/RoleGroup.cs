﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warp.Data.Entities
{
    [Table("RoleGroups", Schema = "Client")]
    public class RoleGroup : EntityBase
    {
        public RoleGroup()
        {
            Roles = new Collection<Role>();
            Users = new Collection<User>();
        }

        public int RoleGroupId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}