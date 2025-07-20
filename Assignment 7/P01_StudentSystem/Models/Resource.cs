using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace P01_StudentSystem
{
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
    public class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(50)")]//(up to 50 characters, unicode)
        public string Url { get; set; } = string.Empty;
        [Column(TypeName = "varchar(max)")]//(not unicode)
        public ResourceType ResourceType { get; set; }//ResourceType(enum – can be Video, Presentation, Document or Other)
        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}