using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Advance_Library_Management_Application.Areas.Identity.Data;

// Add profile data for application users by adding properties to the LibraryApplicationUser class
public class LibraryApplicationUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string FirstName {get; set;}

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string LastName { get; set;}

    [Required]
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    [PersonalData]
    [Column(TypeName = "Int")]
    [Required]
    public int Age { get; set;}

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Address { get; set; } = "ABC Street";

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string Roles { get; set;}
}

