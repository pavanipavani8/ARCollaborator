using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARCollaboration.Models;

[Table("UserInformation")]
public partial class UserInformation
{
    [Key]
    public int UserId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PersonalEmail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MobileNumber { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? City { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<UserInterest> UserInterests { get; set; } = new List<UserInterest>();
}
