using ToDo.Shared.Enums;

namespace ToDo.Shared.Dto.TaskItems
{
    /// <summary>
    /// DTO для создания нового элемента задачи.
    /// </summary>
    public class CreateTaskItemDto 
    {
        /// <summary>
        /// Заголовок элемента задачи.
        /// </summary>
        public string Title { get; set; } = null!;

        /// <summary>
        /// Дополнительное описание элемента задачи.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Флаг, указывающий, что задача занимает весь день.
        /// </summary>
        public bool IsAllDay { get; set; } = false;

        /// <summary>
        /// Дата и время начала задачи.
        /// </summary>
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Дата и время окончания задачи.
        /// </summary>
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Цвет отображения.
        /// </summary>
        public string? Color { get; set; }

        /// <summary>
        /// Флаг, указывающий на повторяемость задачи.
        /// </summary>
        public bool IsRecurring { get; set; } = false;

        /// <summary>
        /// Правило повторения в формате iCal RRULE (применяется, если IsRecurring = true).
        /// </summary>
        public string? RecurrenceRule { get; set; }

        /// <summary>
        /// Текущий статус задачи.
        /// </summary>
        public UserTaskStatus Status { get; set; } = UserTaskStatus.None;

        /// <summary>
        /// Приоритет задачи.
        /// </summary>
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
    }
}
