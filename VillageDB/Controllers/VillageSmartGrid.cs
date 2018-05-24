using System;
using System.Collections.Generic;
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

        // GET api/values
        public IQueryable<Models.VillageSmartGrid> GetVillageSmartGrid()
        {
            return db.VillageSmartGrid;
        }

        // GET api/values/5
        [ResponseType(typeof(Models.VillageSmartGrid))]
        public IHttpActionResult GetVillageSmartGrid(int id)
        {
            Models.VillageSmartGrid villageSmartGrid = db.VillageSmartGrid.Find(id);
            if (villageSmartGrid == null)
            {
                return NotFound();
            }

            return Ok(villageSmartGrid);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
