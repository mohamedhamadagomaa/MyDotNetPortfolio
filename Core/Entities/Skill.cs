using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Core.Entities;

[Table("skills")]
public partial class Skill
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("skillname", TypeName = "text")]
    public string? Skillname { get; set; }

    [Column("skillpercentage")]
    public int? Skillpercentage { get; set; }
}
