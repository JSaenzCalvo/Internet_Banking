using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API.Models;

namespace API.Controllers
{
    public class Deposito_PlazoController : ApiController
    {
        private INTERNET_BANKING_DW1_3C2021Entities db = new INTERNET_BANKING_DW1_3C2021Entities();

        // GET: api/Deposito_Plazo
        public IQueryable<Deposito_Plazo> GetDeposito_Plazo()
        {
            return db.Deposito_Plazo;
        }

        // GET: api/Deposito_Plazo/5
        [ResponseType(typeof(Deposito_Plazo))]
        public IHttpActionResult GetDeposito_Plazo(int id)
        {
            Deposito_Plazo deposito_Plazo = db.Deposito_Plazo.Find(id);
            if (deposito_Plazo == null)
            {
                return NotFound();
            }

            return Ok(deposito_Plazo);
        }

        // PUT: api/Deposito_Plazo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDeposito_Plazo(int id, Deposito_Plazo deposito_Plazo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != deposito_Plazo.Codigo)
            {
                return BadRequest();
            }

            db.Entry(deposito_Plazo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Deposito_PlazoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Deposito_Plazo
        [ResponseType(typeof(Deposito_Plazo))]
        public IHttpActionResult PostDeposito_Plazo(Deposito_Plazo deposito_Plazo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Deposito_Plazo.Add(deposito_Plazo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Deposito_PlazoExists(deposito_Plazo.Codigo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = deposito_Plazo.Codigo }, deposito_Plazo);
        }

        // DELETE: api/Deposito_Plazo/5
        [ResponseType(typeof(Deposito_Plazo))]
        public IHttpActionResult DeleteDeposito_Plazo(int id)
        {
            Deposito_Plazo deposito_Plazo = db.Deposito_Plazo.Find(id);
            if (deposito_Plazo == null)
            {
                return NotFound();
            }

            db.Deposito_Plazo.Remove(deposito_Plazo);
            db.SaveChanges();

            return Ok(deposito_Plazo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Deposito_PlazoExists(int id)
        {
            return db.Deposito_Plazo.Count(e => e.Codigo == id) > 0;
        }
    }
}