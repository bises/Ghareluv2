using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class Udhyog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("RegistrationNumber")]
        public int RegNum { get; set; }

        [Required]
        [Column("RegistrationDate")]
        public DateTimeOffset RegDate { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        public int ClassId { get; set; }

        [Required]
        public int SubClassId { get; set; }

        [Required]
        [Column("CompanyName")]
        [MaxLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int PanNo { get; set; }

        public int AddressId { get; set; }

        [ForeignKey("TypeId")]
        public virtual UdhyogType Type { get; set; }

        [ForeignKey("ClassId")]
        public virtual UdhyogClass Class { get; set; }

        [ForeignKey("SubClassId")]
        public virtual UdhyogSubClass SubClass { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
    }
}
