using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicescaf.Models
{
    public class TeamDbContext : DbContext
    {
        public TeamDbContext(DbContextOptions<TeamDbContext> options) : base(options)
        {

        }

        public DbSet<Teams> Teams { get; set; }

    }
}
