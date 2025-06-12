using ToDo.Shared.Dto.Common;

namespace ToDo.Shared.Dto.TaskItems
{
    /// <summary>
    /// Модель представления для календарного вида задач.
    /// </summary>
    public class CalendarTaskItemsVm
    {
        /// <summary>
        /// Список дней с задачами.
        /// </summary>
        public IList<CalendarDay> Days { get; set; } = new List<CalendarDay>();
    }
}
