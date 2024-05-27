namespace core.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public int UserId { get; set; } 
        public User? User { get; set; } 

        public Todo() { }

        public Todo(string title, string description, DateTime dueDate, int userId)
        {
            this.Title = title;
            this.Description = description;
            this.DueDate = dueDate;
            this.UserId = userId;
        }
    }
}
