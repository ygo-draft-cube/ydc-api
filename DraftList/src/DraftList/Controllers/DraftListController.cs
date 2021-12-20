using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DraftList.Controllers
{
    [Route("api/[controller]")]
    public class DraftListController : ControllerBase
    {
        private readonly IDraftListService service;

        public DraftListController(IDraftListService service)
        {
            this.service = service;
        }
        
        [HttpGet()]
        public IEnumerable<Models.DraftList> GetList()
        {
            return this.service.GetList();
        }
        
        [HttpGet("{id}")]
        public Models.DraftList GetById(string id)
        {
            return this.service.GetById(id);
        }
    }
}
