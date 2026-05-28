using System;
using System.Collections.Generic;

namespace Bead;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public virtual ICollection<Meresek> Mereseks { get; set; } = new List<Meresek>();
}
