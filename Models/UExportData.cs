using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bead.Models
{
    [Serializable]
    public class UExportData
    {
        public DateTime Tol { get; set; }

        public DateTime Ig { get; set; }

        public double AtlagHomerseklet { get; set; }

        public double AtlagCsapadek { get; set; }
    }
}
