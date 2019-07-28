using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCwithAuth.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Time = DateTime.Now.AddHours(2.0).ToString("MM/dd/yyyy h:mm tt");
    }
}