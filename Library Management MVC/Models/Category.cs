using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace Advance_Library_Management_Application.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? BookName { get; set; }

        public string? Available { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
