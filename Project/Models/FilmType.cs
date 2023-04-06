using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class FilmType
    {
        [Key]
        public int FilmTypeID { get; set; }
        public string FilmTypeName { get; set; }
        public string FilmTypeMeta { get; set; }
        public bool FilmTypeHide { get; set; }
        public int FilmTypeOrder { get; set;}
    }
}
