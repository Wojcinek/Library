using Library.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Reserve
    {
            [Key]
            public int id_rental { get; set; }
            [Required]
            [ForeignKey("Books")]
            public Books book { get; set; }
            [Required]
            [ForeignKey("LibraryUser")]
            public LibraryUser user { get; set; }
            [Required]
            [Column(TypeName = "date")]
            public DateTime date_from { get; set; }
            [Required]
            [Column(TypeName = "date")]
            public DateTime date_to { get; set; }



    }
}
