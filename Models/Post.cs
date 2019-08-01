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
        public string Title { get; set; }
        public string Content { get; set; }

        [DisplayFormat(DataFormatString = "{MM/dd/yyyy h:mm tt}")]
        public DateTime TimeStamp { get; set; } 
        public Post()
        {
            TimeStamp = DateTime.Now;
        }
    }
}