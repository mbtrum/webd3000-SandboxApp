using System.ComponentModel.DataAnnotations;

namespace SandboxApp.Models
{    
    public class Photo
    {
        // unique identifier (primary key)
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Image Filename")] // the display name
        public string ImageFilename { get; set; } = string.Empty;

        [Display(Name = "Date Created")] // the display name
        public DateTime CreatedDate { get; set; } 
    }
}
