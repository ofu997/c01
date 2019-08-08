using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MVCwithAuth.Models
{
    public class MVCwithAuthContext : DbContext
    {
        public MVCwithAuthContext (DbContextOptions<MVCwithAuthContext> options)
            : base(options)
        {
        }

        public DbSet<MVCwithAuth.Models.Message> Message { get; set; }
        public DbSet<MVCwithAuth.Models.Post> Post {get;set;}
        // public DbSet<MVCwithAuth.Models.ApplicationUser> ApplicationUser {get;set;}
        // public DbSet<MVCwithAuth.ViewModels.PostViewModel> Post {get;set;}
    }
}