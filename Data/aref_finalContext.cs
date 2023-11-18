using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aref_final.Models;

namespace aref_final.Data
{
    public class aref_finalContext : DbContext
    {
        public aref_finalContext (DbContextOptions<aref_finalContext> options)
            : base(options)
        {
        }

        public DbSet<aref_final.Models.Toy> Toy { get; set; } = default!;
    }
}
