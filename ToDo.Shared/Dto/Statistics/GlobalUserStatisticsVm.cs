﻿using ToDo.Shared.Enums;

namespace ToDo.Shared.Dto.Statistics
{
    /// <summary>
    /// Сводная статистика по задачам пользователя.
    /// </summary>
    public class GlobalTaskStatisticsVm
    {
        /// <summary>
        /// Общее число задач (всех статусов).
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Распределение задач по статусам.
        /// </summary>
        public Dictionary<UserTaskStatus, int> ByStatus { get; set; } = new();

        /// <summary>
        /// Среднее время выполнения задач (в часах).
        /// </summary>
        public double AvgCompletionTimeHours { get; set; }

        /// <summary>
        /// Количество просроченных (не выполненных) задач.
        /// </summary>
        public int OverdueCount { get; set; }
    }
}
