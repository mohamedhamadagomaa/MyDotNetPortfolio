using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Core.Entities;

[Table("projects")]
public partial class Project
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("projectname", TypeName = "text")]
    public string? Projectname { get; set; }

    [Column("projectno")]
    public int? Projectno { get; set; }

    [Column("projectImage", TypeName = "text")]
    public string? ProjectImage { get; set; }

    [Column("projecthosturl", TypeName = "text")]
    public string? Projecthosturl { get; set; }

    [Column("hostIcon", TypeName = "text")]
    public string? HostIcon { get; set; }
}
