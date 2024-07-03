using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DB43 : IEntity
    {
        public DateTime SystemTime { get; set; }
        public short WeeklyWashDay { get; set; }
        public short WeeklyWashHour { get; set; }
        public short DailyWashHour { get; set; }
        public short Minute { get; set; }
        public short Second { get; set; }
    }
}
