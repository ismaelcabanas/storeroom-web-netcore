using Microsoft.AspNetCore.Mvc;

namespace storeroom_web_netcore.Controllers
{
    
    [Route("about")]
    public class AboutController
    {
        [Route("")]
        public string Phone() 
        {
            return "+34666965434";
        }

        [Route("address")]
        public string Address()
        {
            return "My Address";
        }
    }
}