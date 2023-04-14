using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARCollaboration.Models;

public partial class UserInterest
{
    [Key]
    [Column("Interest_Id")]
    public int InterestId { get; set; }

    public int? UserId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TechnicalInterests { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? SocialInterests { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserInterests")]
    public virtual UserInformation? User { get; set; }
}
