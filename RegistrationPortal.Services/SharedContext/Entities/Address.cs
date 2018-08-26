using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationPortal.Services.SharedContext.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public int CountryId { get; set; }

        public int Zone { get; set; }

        public int District { get; set; }

        public int CityTypeId { get; set; }

        public int WardNumber { get; set; }

        public int CityId { get; set; }
        
        public City City { get; set; }

        public Country Country { get; set; }
    }
}
