using ToDo.Shared.Enums;

namespace ToDo.Shared.Dto.Statistics
{
    public class TaskStatusHistoryVm
    {
        /// <summary>Сколько задач было создано по дням</summary>
        public List<DayMetricVm> CreatedHistory { get; set; } = new();

        /// <summary>Сколько задач перешло в статус Done по дням</summary>
        public List<DayMetricVm> CompletedHistory { get; set; } = new();

        /// <summary>Сколько задач стало просроченными по дням</summary>
        public List<DayMetricVm> OverdueHistory { get; set; } = new();

        /// <summary>
        /// А здесь — история по статусам **для завершённых** задач
        /// (например, чтобы строить heat-map / stacked bar по статусам Done / InProgress и т.п.)
        /// </summary>
        public Dictionary<UserTaskStatus, List<DayMetricVm>> StatusHistory { get; set; }
            = new Dictionary<UserTaskStatus, List<DayMetricVm>>();
    }
}
