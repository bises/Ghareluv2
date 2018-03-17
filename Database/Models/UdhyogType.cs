using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class UdhyogType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
