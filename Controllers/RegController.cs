using api3839_17722.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api3839_17722.Controllers
{
    public class RegController : ApiController
    {
        DatabaseContext db = new DatabaseContext();

        [HttpPost]
        public IHttpActionResult reginsert(tblreg reg)
        {
            db.tblregs.Add(reg);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult regget()
        {
            var data = db.tblregs.ToList();
            return Ok(data);
        }
    }
}
