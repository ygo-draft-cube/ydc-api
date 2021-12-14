using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GetDraftList.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GetDraftList.Controllers
{
    [Route("api/[controller]")]
    public class DraftListController : ControllerBase
    {
        [HttpGet("{id}")]
        public DraftList Get(string id)
        {
            var dbFile = System.IO.File.ReadAllText("./Data/data.json");
            var db = JsonConvert.DeserializeObject<DbFileContent>(dbFile);

            return db.DraftLists.Where(list => list.Id.Equals(id)).First();
        }
    }
}
