using Common.Models;
using System;
using System.Web.Http;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    public class InspectionController : ApiController
    {
        // GET: api/Inspection
        public IHttpActionResult Get()
        {
            var inspectionsRepository = new InspectionRepository();
            return Ok(inspectionsRepository.Read());
        }

        // GET: api/Inspection/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Inspection
        public IHttpActionResult Post([FromBody]Inspection inspection)
        {
            inspection.CreatedOn = DateTime.Now;
            var inspectionsRepository = new InspectionRepository();
            inspectionsRepository.Create(inspection);

            return Ok();
        }

        // PUT: api/Inspection/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE: api/Inspection/5
        public IHttpActionResult Delete(int id)
        {
            var inspectionsRepository = new InspectionRepository();
            inspectionsRepository.Delete(id);

            return Ok();
        }
    }
}
