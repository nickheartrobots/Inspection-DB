using Common.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    public class InspectionController : ApiController
    {
        // GET: api/Inspection
        public IEnumerable<Inspection> Get()
        {
            var inspectionsRepository = new InspectionRepository();
            return inspectionsRepository.Read();
        }

        // GET: api/Inspection/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Inspection
        public HttpResponseMessage Post([FromBody]Inspection inspection)
        {
            var inspectionsRepository = new InspectionRepository();
            inspectionsRepository.Create(inspection);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // PUT: api/Inspection/5
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // DELETE: api/Inspection/5
        public void Delete(int id)
        {
            var inspectionsRepository = new InspectionRepository();
            inspectionsRepository.Delete(id);
        }
    }
}
