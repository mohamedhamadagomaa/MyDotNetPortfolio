using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Core.Entities;

[Table("plogs")]
public partial class Plog
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("plogname", TypeName = "text")]
    public string? Plogname { get; set; }

    [Column("plogimage", TypeName = "text")]
    public string? Plogimage { get; set; }

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }
}
