using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ActCompl.Models;

namespace ActCompl.Models
{
    public class ActComplContext : DbContext
    {
        public ActComplContext (DbContextOptions<ActComplContext> options)
            : base(options)
        {
        }

        public DbSet<ActCompl.Models.Alumnos> Alumnos { get; set; }

        public DbSet<ActCompl.Models.Instructor> Instructor { get; set; }
    }
}
