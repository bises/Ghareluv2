﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using RegistrationPortal.Models;
using Database.Repository;

namespace RegistrationPortal.Controllers
{
    [RoutePrefix("api/People")]
    public class PeopleController : ApiController
    {
        private PortalDbContext db = new PortalDbContext();
        //private RegistrationPortalContext db1 = new RegistrationPortalContext();

        // GET: getPeople
        [Route("")]
        public IList<Database.Models.Person> GetPeople()
        {            
            return db.Persons.ToList();
        }

        //    // GET: api/People/5
        //    [ResponseType(typeof(Person))]
        //    public async Task<IHttpActionResult> GetPerson(int id)
        //    {
        //        Person person = await db.People.FindAsync(id);
        //        if (person == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(person);
        //    }

        //    // PUT: api/People/5
        //    [ResponseType(typeof(void))]
        //    public async Task<IHttpActionResult> PutPerson(int id, Person person)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        if (id != person.PersonId)
        //        {
        //            return BadRequest();
        //        }

        //        db.Entry(person).State = EntityState.Modified;

        //        try
        //        {
        //            await db.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PersonExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return StatusCode(HttpStatusCode.NoContent);
        //    }

        //    // POST: api/People
        //    [ResponseType(typeof(Person))]
        //    public async Task<IHttpActionResult> PostPerson(Person person)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        db.People.Add(person);
        //        await db.SaveChangesAsync();

        //        return CreatedAtRoute("DefaultApi", new { id = person.PersonId }, person);
        //    }

        //    // DELETE: api/People/5
        //    [ResponseType(typeof(Person))]
        //    public async Task<IHttpActionResult> DeletePerson(int id)
        //    {
        //        Person person = await db.People.FindAsync(id);
        //        if (person == null)
        //        {
        //            return NotFound();
        //        }

        //        db.People.Remove(person);
        //        await db.SaveChangesAsync();

        //        return Ok(person);
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }

        //    private bool PersonExists(int id)
        //    {
        //        return db.People.Count(e => e.PersonId == id) > 0;
        //    }
    }
}