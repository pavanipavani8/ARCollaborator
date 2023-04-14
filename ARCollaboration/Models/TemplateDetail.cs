using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARCollaboration.Models;

public partial class TemplateDetail
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string? TemplateName { get; set; }

    [Column("TemplateFileURL")]
    [StringLength(250)]
    public string? TemplateFileUrl { get; set; }

    [StringLength(100)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "date")]
    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }
}
