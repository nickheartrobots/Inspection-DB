using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [EnableCorsAttribute("http://localhost:4200", "*", "*")]
    public class InspectionController : ApiController
    {
        // GET: api/Inspection
        public IEnumerable<Inspection> Get()
        {
            var inspectionsRepository = new InspectionsRepository();
            return inspectionsRepository.Read();
        }

        // GET: api/Inspection/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Inspection
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Inspection/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Inspection/5
        public void Delete(int id)
        {
        }
    }
}
