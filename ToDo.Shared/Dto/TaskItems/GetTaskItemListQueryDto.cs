using ToDo.Shared.Enums;

namespace ToDo.Shared.Dto.TaskItems
{
    /// <summary>
    /// DTO для получения списка элементов задач с параметрами фильтрации, сортировки и пагинации.
    /// </summary>
    public class GetTaskItemListQueryDto 
    {
        /// <summary>
        /// Номер страницы (начиная с 1).
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Размер страницы (количество элементов на странице).
        /// </summary>
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// Фильтрация по статусу задачи.
        /// </summary>
        public UserTaskStatus? Status { get; set; }

        /// <summary>
        /// Фильтрация по приоритету задачи.
        /// </summary>
        public TaskPriority? Priority { get; set; }

        /// <summary>
        /// Фильтрация по флагу: задача на весь день.
        /// </summary>
        public bool? IsAllDay { get; set; }

        /// <summary>
        /// Фильтрация по дате начала (StartDate >= DateFrom).
        /// </summary>
        public DateTimeOffset? DateFrom { get; set; }

        /// <summary>
        /// Фильтрация по дате окончания (EndDate <= DateTo).
        /// </summary>
        public DateTimeOffset? DateTo { get; set; }

        /// <summary>
        /// Поиск по ключевым словам в заголовке или описании (не более 100 символов).
        /// </summary>
        public string? Search { get; set; }

        /// <summary>
        /// Поле для сортировки (например, "StartDate", "Priority").
        /// </summary>
        public string? SortBy { get; set; }

        /// <summary>
        /// Порядок сортировки: true — по убыванию, false — по возрастанию.
        /// </summary>
        public bool SortDescending { get; set; }
    }
}