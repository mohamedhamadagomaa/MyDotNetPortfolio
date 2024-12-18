using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Plog
{
    public long Id { get; set; }

    public string? Plogname { get; set; }

    public string? Plogimage { get; set; }

    public string? Description { get; set; }
}
