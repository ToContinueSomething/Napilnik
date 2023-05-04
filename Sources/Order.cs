namespace Napilnik.Sources
{
    public class Order
    {
        public string Paylink { get; private set; }

        public Order(string paylink)
        {
            Paylink = paylink;
        }
    }
}
