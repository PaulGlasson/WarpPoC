﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using hGem.Core.Data;

namespace hGem.Data.Entities
{
    public class TextResourceIdentifier : EntityBase
    {
        [Required]
        public string TextResourceCode { get; set; }

        [DefaultValue(false)]
        public bool ClientOverridable { get; set; }

        public virtual IEnumerable<TextResource> TextResources { get; set; }
    }
}