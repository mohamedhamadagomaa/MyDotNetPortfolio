using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Core.Entities;

[Table("Owner")]
public partial class Owner
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column(TypeName = "text")]
    public string? OwnerName { get; set; }

    [Column(TypeName = "text")]
    public string? JobTitle { get; set; }

    [Column(TypeName = "text")]
    public string? MainSkills { get; set; }

    [Column(TypeName = "text")]
    public string? OwnerImage { get; set; }

    [Column(TypeName = "text")]
    public string? OnlineCv { get; set; }

    [Column(TypeName = "text")]
    public string? OfflineCv { get; set; }

    [Column(TypeName = "text")]
    public string? Location { get; set; }

    [Column(TypeName = "text")]
    public string? Email { get; set; }

    [Column(TypeName = "text")]
    public string? Education { get; set; }

    public long? MobileNum { get; set; }

    [Column(TypeName = "text")]
    public string? Languages { get; set; }

    [Column(TypeName = "text")]
    public string? SocialLink { get; set; }

    [Column(TypeName = "text")]
    public string? SocialIcon { get; set; }
}
