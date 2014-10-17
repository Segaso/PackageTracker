using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker {
    class Package {
        public int PackageUID { get; set; }
        public string UPC { get; set; }
        public string Carrier { get; set; }
        public string Sender { get; set; }
        public int PackageStatus { get; set; }
    }
}
