namespace ToDo.Shared.Dto.Statistics
{
    public class DailyTaskStatisticsVm
    {
        public IList<DayStatisticItem> History { get; set; } = new List<DayStatisticItem>();
    }
}
