using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Film
    {
        [Key]
        public int FilmID { get; set; }
        public string FilmName { get; set;}
        public string FilmIMG { get; set;}
        public int FilmEP { get; set;}
        public int FilmView { get; set; }
        public string FilmLink { get; set; }
        public string FilmMeta { get; set; }
        public int FilmHide { get; set;}
        public int FilmOrder { get; set;}

    }
}
