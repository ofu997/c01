using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MVCwithAuth.Models
{
    public class Post
    {
            public int Id { get; set; }
            // public string OwnerId {get;set;}
        [Required(ErrorMessage="Title is required")]
        public string Title { get; set; }
            [Required(ErrorMessage="Content is required")]
            public string Content { get; set; }
            
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy h:mm tt}")]
        [Display(Name="Created at")]
            public DateTime TimeStamp { get; set; } 
        [Display(Name="Contact")]
            public string userEmail {get;set;}
                public Post()
                {
                    TimeStamp = DateTime.Now;
                }
    }
}