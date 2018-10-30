using System.Collections.Generic;
using System.Linq;
using storeroom_web_netcore.Data;
using storeroom_web_netcore.Models;

namespace storeroom_web_netcore.Services
{
    public class SqlStoreroomData : IStoreroomData
    {
        private StoreroomDbContext _context;

        public SqlStoreroomData(StoreroomDbContext dbContext)
        {
            _context = dbContext;
        }
        public Storeroom Add(Storeroom storeroom)
        {
            _context.Storerooms.Add(storeroom);
            _context.SaveChanges();
            return storeroom;
        }

        public Storeroom Get(int id)
        {
            return _context.Storerooms.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Storeroom> GetAll()
        {
            return _context.Storerooms.OrderBy(s => s.Name);
        }
    }
}