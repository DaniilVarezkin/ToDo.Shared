using ToDo.Shared.Enums;

namespace ToDo.Shared.Dto.TaskItems
{
    /// <summary>
    /// DTO для списка задач
    /// </summary>
    public class TaskItemLookupDto 
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsAllDay { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string? Color { get; set; }
        public bool IsRecurring { get; set; }
        public string? RecurrenceRule { get; set; }
        public UserTaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset? CompletedDate { get; set; }        
    }
}