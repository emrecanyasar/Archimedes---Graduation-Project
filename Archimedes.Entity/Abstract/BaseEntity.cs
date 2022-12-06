﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity.Abstract
{
    public class BaseEntity 
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}