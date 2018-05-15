using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvMonitoringSystem.Models
{
    public class BasicParameter
    {
        public int BasicParameterId { get; set; }
        public int Pgn { get; set; }
        public int Pgl { get; set; }
        public string Acronym { get; set; }
        public string SpnName { get; set; }
        public string SpnNameRu { get; set; }
        public string DataRange { get; set; }
        public string DataSource { get; set; }
    }
}
