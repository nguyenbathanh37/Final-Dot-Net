using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuLink { get; set; }
        public string MenuMeta { get; set; }
        public int MenuHide { get; set; }
        public int MenuOrder { get; set; }
    }
}
