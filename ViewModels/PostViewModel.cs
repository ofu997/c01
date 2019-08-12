using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MVCwithAuth.ViewModels    
{
    public class PostViewModel
    {
        // we may not need this
        // public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{MM/dd/yyyy h:mm tt}")]
        [Display(Name="Created at")]
        public DateTime TimeStamp { get; set; } 

        public IFormFile File {get;set;}
        public PostViewModel()
        {
            TimeStamp = DateTime.Now;
        }
    }
}