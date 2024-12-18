using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Timeline
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Daterange { get; set; }

    public string? Description { get; set; }

    public string? TimeLineIcon { get; set; }
}
