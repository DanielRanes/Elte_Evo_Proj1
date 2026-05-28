using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bead.Models
{
    public class ViewData
    {
        public int MeroId { get; set; }
        public string MeroType { get; set; }

        public double Homerseklet { get; set; }
        public double? HarmatPont { get; set; }
        public double? Paratartalom { get; set; }

        public double? Legnyomas { get; set; }
        public double? Csapadek { get; set; }

        public DateTime Date { get; set; }
        public bool IsDailyMax { get; set; }
    }
}
