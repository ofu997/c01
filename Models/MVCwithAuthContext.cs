using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCwithAuth.Models
{
    public class MVCwithAuthContext : DbContext
    {
        public MVCwithAuthContext (DbContextOptions<MVCwithAuthContext> options)
            : base(options)
        {
        }

        public DbSet<MVCwithAuth.Models.Message> Message { get; set; }
    }
}