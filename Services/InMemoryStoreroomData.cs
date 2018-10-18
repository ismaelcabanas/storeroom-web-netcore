using System.Collections.Generic;
using storeroom_web_netcore.Models;

namespace storeroom_web_netcore.Services
{
    public class InMemoryStoreroomData : IStoreroomData
    {
        private List<Storeroom> _storerooms;

        public IEnumerable<Storeroom> GetAll()
        {
            _storerooms = new List<Storeroom>
            {
                new Storeroom {Id = 1, Name = "Storeroom 1"},
                new Storeroom {Id = 2, Name = "Storeroom 2"}
            };
            return _storerooms;
        }
    }
}