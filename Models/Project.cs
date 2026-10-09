using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage =  "Project title is required.")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLengthAttribute(300)]
        public string ShortDescription { get; set; } = string.Empty;

        public string DetailedDescription { get; set; } = string.Empty;

        public string Technologies { get; set; } = string.Empty; // e.g., "C#, ASP.NET Core MVC, MySQL"

        public string? GithubUrl { get; set; }

        public string? DemoUrl { get; set; }

        public bool IsFeatured { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}