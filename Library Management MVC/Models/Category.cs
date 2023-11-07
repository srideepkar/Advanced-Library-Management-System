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

        public string? Author { get; set; }

        [Required]
        public string? ISBN { get; set; }

        public string? Genre { get; set; }

        public string? Series { get; set; }

        public string? Publisher { get; set; }

        public DateTime? PublishDate { get; set; }

        public bool Available { get; set; } = false;

        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
