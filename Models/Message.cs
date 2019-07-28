using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCwithAuth.Models
{
    public class Message
    {
        // var user=await GetCurrentUserAsync();
        // private readonly  UserManager<IdentityUser> _userManager;
        public int Id { get; set; }
        // public string user=> User.Identity; 
        public string Title { get; set; }
        // public string ListTags {get;set;}
        [Display(Name="Hashtags")]
        public string Tags {get;set;}
        public string Content {get;set;}

        // [DataType(DataType.DateTime)]
        public string Time = DateTime.Now.AddHours(2.0).ToString("MM/dd/yyyy h:mm tt");
    }
}