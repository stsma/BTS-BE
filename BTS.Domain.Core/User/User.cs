﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS.Domain.Core.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }
    }
}
