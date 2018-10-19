using System.Collections.Generic;
using storeroom_web_netcore.Models;

namespace storeroom_web_netcore.ViewModels
{
    public class StoreroomViewModel
    {
        public string Message {get;}
        public IEnumerable<Storeroom> Storerooms {get;}

        public StoreroomViewModel(IEnumerable<Storeroom> storerooms, string message)
        {
            this.Storerooms = storerooms;
            this.Message = message;
        }
    }
}