using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MVCwithAuth.Models
{
    public class ApplicationUser : IdentityUser
    {
        public  string personalUserName { get; set; } // example, not necessary
    }   
}

