using Library.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Books
    {

        [Key]
        public int ID { get; set; }
        [Required]

        public string Title { get; set; }

        public string Author { get; set; }

        public int BookEditionYear { get; set; }
    }
}
