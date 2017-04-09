using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenData
{
    public class RainTenMin
    {
        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public string County { get; set; }
        public string Township { get; set; }
        public decimal TWD67Lon { get; set; }
        public decimal TWD67Lat { get; set; }
        public decimal Rainfall10min { get; set; }
        public decimal Rainfall1hr { get; set; }
        public decimal Rainfall3hr { get; set; }
        public decimal Rainfall6hr { get; set; }
        public decimal Rainfall12hr { get; set; }
        public decimal Rainfall24hr { get; set; }
        public decimal Now { get; set; }
        public string Unit { get; set; }
        public string PublishTime { get; set; }
    }
}
