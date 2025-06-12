using ToDo.Shared.Enums;

namespace ToDo.Shared.Dto.TaskItems
{
    /// <summary>
    /// DTO для частичного обновления элемента задачи.
    /// </summary>
    public class PartialUpdateTaskItemDto
    {
        /// <summary>
        /// Идентификатор обновляемого элемента задачи.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Новое значение заголовка задачи (необязательно).
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Новое значение описания задачи (необязательно).
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Обновление флага «задача на весь день» (необязательно).
        /// </summary>
        public bool? IsAllDay { get; set; }

        /// <summary>
        /// Новое значение даты и времени начала задачи (необязательно).
        /// </summary>
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// Новое значение даты и времени окончания задачи (необязательно).
        /// </summary>
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// Обновление цвета отображения (необязательно).
        /// </summary>
        public string? Color { get; set; }

        /// <summary>
        /// Обновление флага повторяемости задачи (необязательно).
        /// </summary>
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// Новое правило повторения в формате iCal RRULE (необязательно).
        /// </summary>
        public string? RecurrenceRule { get; set; }

        /// <summary>
        /// Обновление статуса задачи (необязательно).
        /// </summary>
        public UserTaskStatus? Status { get; set; }

        /// <summary>
        /// Обновление приоритета задачи (необязательно).
        /// </summary>
        public TaskPriority? Priority { get; set; }
    }
}
