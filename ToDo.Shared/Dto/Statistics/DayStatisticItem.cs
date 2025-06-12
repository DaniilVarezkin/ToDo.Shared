namespace ToDo.Shared.Dto.Statistics
{
    public class DayStatisticItem
    {
        public DateTimeOffset Day { get; set; }
        public int CompletedCount { get; set; }
    }
}