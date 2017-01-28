using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileResults.SqlRepository.Model
{
    public class Outcome
    {
        public string Text { get; set; }
        public int? HoursEstimated { get; set; }
        public int? HoursActual { get; set; }
    }
}
