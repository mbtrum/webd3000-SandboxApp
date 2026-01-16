namespace SandboxApp.Models
{    
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageFilename { get; set; } = string.Empty;        
        public DateTime CreatedDate { get; set; }
    }

}
