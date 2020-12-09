using System.Collections.Generic;

namespace RMotownFestival.DAL.Domain
{
    public class Schedule
    {
        public List<ScheduleItem> Items { get; set; }

        public Schedule()
        {
            Items = new List<ScheduleItem>();
        }
    }
}
