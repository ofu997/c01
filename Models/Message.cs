using System;
using System.ComponentModel.DataAnnotations;

namespace MVCwithAuth.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content {get;set;}

        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }
    }
}