using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo1.Controllers {
    [Route ("api/[controller]")]
    public class MyController : Controller {

        KSContext db;

        public MyController (KSContext _db) {
            this.db = _db;
        }

        [HttpGet ("/api/spots")]
        public IEnumerable<Record> Get (string k = "", string z = "", Ticketinfo t = Ticketinfo.Empty) {
            var data = this.db.ScenicSpots.AsQueryable ();
            if (!String.IsNullOrEmpty (k)) {
                data = data.Where (x => x.Name.Contains (k) || x.Description.Contains (k));
            }
            if (!String.IsNullOrEmpty (z)) {
                data = data.Where (x => x.Zone == z);
            }
            if (t != Ticketinfo.Empty) {
                data = data.Where (x => x.Ticketinfo == t);
            }
            return data.Take (10);
        }

        [HttpGet ("/api/spots/{id}")]
        public Record GetById (string id) {
            return this.db.ScenicSpots.Find (id);
        }

        [HttpGet ("/importdb")]
        public IActionResult ImportDB () {
            All data = All.FromJson (System.IO.File.ReadAllText ("data.json"));

            this.db.AddRange (data.Result.Records);

            this.db.SaveChanges ();

            return Content ("OK");
        }

    }
}