using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DraftList.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DraftList.Controllers
{
    [Route("api/[controller]")]
    public class DraftListService: IDraftListService
    {
        public Models.DraftList GetById(string id)
        {
            var dbFile = System.IO.File.ReadAllText("./Data/data.json");
            var db = JsonConvert.DeserializeObject<DbFileContent>(dbFile);

            return db.DraftLists.Where(list => list.Id.Equals(id)).First();
        }
        
        public IEnumerable<Models.DraftList> GetList()
        {
            var dbFile = System.IO.File.ReadAllText("./Data/data.json");
            var db = JsonConvert.DeserializeObject<DbFileContent>(dbFile);

            return db.DraftLists;
        }
    }
}
