using System.Collections.Generic;

namespace DraftList
{
    public interface IDraftListService
    {
        public Models.DraftList GetById(string id);
        public IEnumerable<Models.DraftList> GetList();
    }
}