using Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RegistrationPortal.Controllers
{
    [RoutePrefix("api/Address")]
    public class AddressController : ApiController
    {
        private PortalDbContext db = new PortalDbContext();

        // GET: getCities
        [Route("Cities")]
        public IList<Database.Models.City> GetCities()
        {
            return db.Cities.ToList();
        }

        // GET: getCountries
        [Route("Countries")]
        public IList<Database.Models.Country> GetCountries()
        {
            return db.Countries.ToList();
        }
    }
}
