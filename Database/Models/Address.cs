using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public int CountryId { get; set; }

        public int Zone { get; set; }

        public int District { get; set; }

        public int CityTypeId { get; set; }

        public int WardNumber { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
