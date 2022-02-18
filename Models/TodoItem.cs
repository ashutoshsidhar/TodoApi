using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool Done { get; set; }
        public DateTime UploadedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public int bid {get; set;}
          [ForeignKey("bid")]
          [JsonIgnore]
        public virtual Board Boards {get; set;}
         
    }

}