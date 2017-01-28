using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileResults.SqlRepository.Model
{
    public class Week
    {
        public int WeekOfYear { get; set; }
        public int Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comments { get; set; }
        public IList<DailyOutcome> DailyOutcomes { get; set; }
        public IList<Outcome> WeeklyOutcomes { get; set; }        
    }
}
