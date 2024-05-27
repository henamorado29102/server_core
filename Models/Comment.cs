using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core.Models
{
    [Table("Comments")] 
    public class Comment
    {
        [Key] 
        public int Id { get; set; } 

        [Required]
        [MaxLength(1000)] 
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int TodoId { get; set; } 
        public Todo? Todo { get; set; } 

        public Comment() { }

        public Comment(string content, int todoId)
        {
            this.Content = content;
            this.TodoId = todoId;
        }
    }
}
