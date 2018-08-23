using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RegistrationPortal.Models
{
    public abstract class EntityBase
    {
        public DateTimeOffset? DateCreated { get; set; }

        public string UserCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; }

        public string UserModified { get; set; }
    }
}