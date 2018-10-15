namespace storeroom_web_netcore
{
    public interface IGreeter
    {
        string GetGreeterMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        public string GetGreeterMessageOfTheDay()
        {
            return "Greeting!!";
        }
    }
}