using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicescaf.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            TeamDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<TeamDbContext>();



            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Teams.Any())
            {
                context.Teams.AddRange(
                    new Teams
                    {
                        TeamName = "Chelsea",
                        Record = 2

                    }
                    );
            }
        }
    }
}
