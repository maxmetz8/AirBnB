using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AirB_B.Models;

namespace AirB_B.Data
{
    public class AirB_BContext : DbContext
    {
        public AirB_BContext (DbContextOptions<AirB_BContext> options)
            : base(options)
        {
        }

        public DbSet<AirB_B.Models.User> User { get; set; } = default!;
    }
}
