namespace MvcTodoApp.Models
{
    /// <summary>
    /// يمثل نموذج مهمة في التطبيق.
    /// </summary>
    public class TaskItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public bool IsComplete { get; set; }
    }
}
