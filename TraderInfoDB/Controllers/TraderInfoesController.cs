using System;
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
using TraderInfoDB.Models;

namespace TraderInfoDB.Controllers
{
    public class TraderInfoesController : ApiController
    {
        private TraderInfoDBContext db = new TraderInfoDBContext();

        // GET: api/TraderInfoes
        public IQueryable<TraderInfo> GetTraderInfoes()
        {
            return db.TraderInfoes;
        }

        // GET: api/TraderInfoes/5
        [ResponseType(typeof(TraderInfo))]
        public async Task<IHttpActionResult> GetTraderInfo(string id)
        {
            TraderInfo traderInfo = await db.TraderInfoes.FindAsync(id);
            if (traderInfo == null)
            {
                return NotFound();
            }

            return Ok(traderInfo);
        }

        // PUT: api/TraderInfoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTraderInfo(string id, TraderInfo traderInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != traderInfo.Id)
            {
                return BadRequest();
            }

            db.Entry(traderInfo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TraderInfoExists(id))
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

        // POST: api/TraderInfoes
        [ResponseType(typeof(TraderInfo))]
        public async Task<IHttpActionResult> PostTraderInfo(TraderInfo traderInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TraderInfoes.Add(traderInfo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TraderInfoExists(traderInfo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = traderInfo.Id }, traderInfo);
        }

        // DELETE: api/TraderInfoes/5
        [ResponseType(typeof(TraderInfo))]
        public async Task<IHttpActionResult> DeleteTraderInfo(string id)
        {
            TraderInfo traderInfo = await db.TraderInfoes.FindAsync(id);
            if (traderInfo == null)
            {
                return NotFound();
            }

            db.TraderInfoes.Remove(traderInfo);
            await db.SaveChangesAsync();

            return Ok(traderInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TraderInfoExists(string id)
        {
            return db.TraderInfoes.Count(e => e.Id == id) > 0;
        }
    }
}