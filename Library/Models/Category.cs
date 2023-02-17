using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set;}
        [Required]

        public string Name { get; set;} 

        public string Surname { get; set;}  


    }
}
