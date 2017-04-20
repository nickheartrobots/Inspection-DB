﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    public class InspectionController : ApiController
    {
        // GET: api/Inspection
        public IEnumerable<Inspection> Get()
        {
            var inspectionRepository = new InspectionRepository();
            return inspectionRepository.Retrieve();
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