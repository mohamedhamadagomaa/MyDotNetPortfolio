using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Core.Entities;

[Table("timeline")]
public partial class Timeline
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("title", TypeName = "text")]
    public string? Title { get; set; }

    [Column("subtitle", TypeName = "text")]
    public string? Subtitle { get; set; }

    [Column("daterange", TypeName = "text")]
    public string? Daterange { get; set; }

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }
}
