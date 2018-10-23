using System.Collections.Generic;
using System.Linq;
using storeroom_web_netcore.Models;

namespace storeroom_web_netcore.Services
{
    public class InMemoryStoreroomData : IStoreroomData
    {
        private List<Storeroom> _storerooms;

        public InMemoryStoreroomData()
        {
            _storerooms = new List<Storeroom>
            {
                new Storeroom {Id = 1, Name = "Storeroom 1"},
                new Storeroom {Id = 2, Name = "Storeroom 2"}
            };
        }

        public Storeroom Add(Storeroom storeroom)
        {
            storeroom.Id = _storerooms.Max(s => s.Id) + 1;
            _storerooms.Add(storeroom);
            return storeroom;
        }

        public Storeroom Get(int id)
        {
            return _storerooms.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Storeroom> GetAll()
        {            
            return _storerooms.OrderBy(s => s.Name);
        }


    }
}