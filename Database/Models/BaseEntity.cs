using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public abstract class BaseEntity
    {
        [Required]
        [DefaultValue(false)]
        public virtual bool IsDeleted { get; set; }

        [Required]
        public DateTimeOffset CreatedDate { get; set; }

        [Required]
        public int CreatedByUserId { get; set; }

        [Required]
        public DateTimeOffset LastUpdateDate { get; set; }

        [Required]
        public int LastUpdateBy { get; set; }


    }
}
