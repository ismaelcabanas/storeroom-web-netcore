using Microsoft.AspNetCore.Mvc;

namespace storeroom_web_netcore.Controllers
{
    
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone() 
        {
            return "+34666965434";
        }

        public string Address()
        {
            return "My Address";
        }
    }
}