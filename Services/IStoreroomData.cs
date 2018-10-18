using System.Collections.Generic;
using storeroom_web_netcore.Models;

namespace storeroom_web_netcore.Services
{
    public interface IStoreroomData
    {
        IEnumerable<Storeroom> GetAll();
    }
}