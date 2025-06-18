using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Shared.Dto.Statistics
{
    public class DayMetricVm
    {
        public DateTimeOffset Day { get; set; }
        public int Count { get; set; }
    }
}
