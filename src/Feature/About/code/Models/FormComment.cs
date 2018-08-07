﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agency.Feature.About.Models
{
    public class FormComment
    {
        [Required]
        public virtual string Name { get; set; }
        [Required, EmailAddress]
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        [Required]
        public virtual string Comment { get; set; }
    }
}