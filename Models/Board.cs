
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TodoApi.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        // public virtual ICollection<TodoItem> TodoItems { get; set; }
    
    }
}