using jar.api.Interfaces;


namespace jar.api.Models
{
   
    public class Coin : ICoin
    {
      
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
    }
}
