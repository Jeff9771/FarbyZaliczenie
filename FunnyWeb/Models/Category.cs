using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FunnyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Nazwa Farby")]
        public string Name { get; set; }

        [Range(1,100000, ErrorMessage = "Numer farby powinien być w granicy 1-100000")]
        [DisplayName("Numer Farby")]
        public int PaintNumber { get; set; }



        [MaxLength(30)]
        [DisplayName("Typ Farby")]
        public string Type { get; set; }


    }
}
