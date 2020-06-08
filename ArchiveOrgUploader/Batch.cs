using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveOrgUploader
{
    class Batch
    {
        public string FilePath { get; set; }
        public int DPI { get; set; }
        public int BitDepth { get; set; }
        public string Scanner { get; set; }
        public bool Raw { get; set; }
        public bool ICM { get; set; }
        public bool Q13 { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public string System { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Serial { get; set; }
        public string Region { get; set; }
        public string Languages { get; set; }
        public bool Cover { get; set; }
        public bool Media { get; set; }
        public bool Manual { get; set; }
        public bool Extras { get; set; }
    }
}
