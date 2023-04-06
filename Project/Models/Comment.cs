using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public bool CommentHide { get; set; }
        public int FilmID { get; set; }
        public int UserID { get; set; }
    }
}
