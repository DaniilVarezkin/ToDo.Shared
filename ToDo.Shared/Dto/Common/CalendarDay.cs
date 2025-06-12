using ToDo.Shared.Dto.TaskItems;

namespace ToDo.Shared.Dto.Common
{
    /// <summary>
    /// Описание задач на конкретный день для календаря.
    /// </summary>
    public class CalendarDay
    {
        /// <summary>
        /// Дата (без времени) дня.
        /// </summary>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Список DTO задач, попадающих на этот день.
        /// </summary>
        public IList<TaskItemLookupDto> Tasks { get; set; } = new List<TaskItemLookupDto>();
    }
}