using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogIMG { get; set; }
        public string BlogContent { get; set; }
    }
}
