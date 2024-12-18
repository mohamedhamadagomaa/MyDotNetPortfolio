using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Social
{
    public int Id { get; set; }

    public string? SocialLink { get; set; }

    public string? SocialIcon { get; set; }
}
