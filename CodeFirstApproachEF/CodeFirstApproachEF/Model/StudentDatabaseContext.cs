﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachEF.Model
{
    class StudentDatabaseContext : DbContext
    {
        public DbSet<Student> students { get; set; }
    }
}
