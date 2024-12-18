using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Project
{
    public long Id { get; set; }

    public string? Projectname { get; set; }

    public int? Projectno { get; set; }

    public string? Projectimage { get; set; }

    public string? Projecthosturl { get; set; }
}
