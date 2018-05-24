using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using VillageDB.Models;

namespace VillageDB.Controllers
{
    public class VillageSmartGrid : ApiController
    {
        private VillageSmartGridContext db = new VillageSmartGridContext();

        private bool GridInfo(int a)
        {
            return db.VillageSmartGrid.Count(b => b.Id == a) > 0;
        }


        // GET api/values
        public IQueryable<Models.VillageSmartGrid> GetVillageSmartGrid()
        {
            return db.VillageSmartGrid;
        }

        // GET api/values/5
        [ResponseType(typeof(Models.VillageSmartGrid))]
        public IHttpActionResult GetVillageSmartGrid(int a)
        {
            Models.VillageSmartGrid villageSmartGrid = db.VillageSmartGrid.Find(a);
            if (villageSmartGrid == null)
            {
                return NotFound();
            }

            return Ok(villageSmartGrid);
        }

        // POST api/values
        public IHttpActionResult PostVillageSmartGrid(Models.VillageSmartGrid villageSmartGrid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VillageSmartGrid.Add(villageSmartGrid);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (GridInfo(villageSmartGrid.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
               
            }

            return CreatedAtRoute("API", new {id = villageSmartGrid.Id}, villageSmartGrid);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


    }
}
