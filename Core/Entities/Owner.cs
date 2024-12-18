using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Owner
{
    public long Id { get; set; }

    public string? OwnerName { get; set; }

    public string? JobTitle { get; set; }

    public string? MainSkills { get; set; }

    public string? OwnerImage { get; set; }

    public string? OnlineCv { get; set; }

    public string? OfflineCv { get; set; }

    public string? Location { get; set; }

    public string? Email { get; set; }

    public string? Education { get; set; }

    public long? MobileNum { get; set; }

    public string? Languages { get; set; }
}
