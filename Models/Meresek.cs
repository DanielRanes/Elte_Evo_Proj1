using System;
using System.Collections.Generic;

namespace Bead;

public partial class Meresek
{
    public int Id { get; set; }

    public int MeroId { get; set; }

    public string MeroType { get; set; } = null!;

    public DateTime Date { get; set; }

    public double Homerseklet { get; set; }

    public double? Harmatpont { get; set; }

    public double? Legnyomas { get; set; }

    public double? Csapadek { get; set; }

    public virtual User Mero { get; set; } = null!;
}
