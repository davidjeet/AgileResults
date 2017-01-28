using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileResults.SqlRepository.Model
{
    public class DailyOutcome
    {
        public DateTime Date { get; set; }
        public IList<Outcome> Outcomes { get; set; }
        public string Comments { get; set; }       
    }
}
