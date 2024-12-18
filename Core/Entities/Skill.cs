using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Skill
{
    public long Id { get; set; }

    public string? Skillname { get; set; }

    public int? Skillpercentage { get; set; }
}
