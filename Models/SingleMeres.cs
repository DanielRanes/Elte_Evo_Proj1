using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bead.Models
{
    public class SingleMeres
    {
        public int MeresId { get; set; }
        public string MeresType { get; set; }
        public DateTime MeresDate { get; set; }
        public double MeresHomerseklet { get; set; }
        public double? MeresHarmatpont { get; set; }
        public double? MeresLegnyomas { get; set; }
        public double? MeresCsapadek { get; set; }
    }
}
