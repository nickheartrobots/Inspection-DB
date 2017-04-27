using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [EnableCorsAttribute("http://localhost:4200", "*", "*")]
    public class InspectorController : ApiController
    {
        // GET: api/Inspector
        public IEnumerable<Inspector> Get()
        {
            var inspectorRepository = new InspectorRepository();
            return inspectorRepository.Read();
        }

        // GET: api/Inspector/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Inspector
        public void Post([FromBody]Inspector inspector)
        {
            var inspectorRepository = new InspectorRepository();
            inspectorRepository.Create(inspector);

            //return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // PUT: api/Inspector/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Inspector/5
        public void Delete(int id)
        {
        }
    }
}
