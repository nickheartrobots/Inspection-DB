using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [EnableCorsAttribute("http://localhost:4200", "*", "*")]
    public class VehicleController : ApiController
    {
        // GET: api/Vehicle
        public IEnumerable<Vehicle> Get()
        {
            var vehicleRepository = new VehicleRepository();
            return vehicleRepository.Read();
        }

        // GET: api/Vehicle/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vehicle
        public HttpResponseMessage Post([FromBody]Vehicle vehicle)
        {
            var vehicleRepository = new VehicleRepository();
            vehicleRepository.Create(vehicle);

            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(vehicle));

            return response;
        }

        // PUT: api/Vehicle/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vehicle/5
        public void Delete(int id)
        {
        }
    }
}
