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
    [Display(Name="")]
        public int Id { get; set; }
    [Display(Name="Author(s)")]
        public string Author {get;set;}
    [Display(Name="Title of work")]
        public string Title { get; set; }
        public string City {get;set;}
        public string Publisher {get;set;}
        public string Year {get;set;}
    [Display(Name = "Hashtags")]
        public string Tags { get; set; }
    [Display(Name="Description")]
        public string Content { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Created at:")]
    [DisplayFormat(DataFormatString = "{MM/dd/yyyy h:mm tt}")]
        public DateTime TimeStamp { get; set; } 
    [Display(Name="Contact")]
        public string userEmail {get;set;}
            public Message()
            {
                TimeStamp = DateTime.Now;
            }
    }
}