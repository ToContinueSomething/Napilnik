using Napilnik.Sources;

namespace Napilnik
{
    public class Shop
    {
        private Warehouse _warehouse;

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public IReadOnlyStorage Warehouse => _warehouse;

        public Cart Cart()
        {
            return new Cart(_warehouse);
        }
    }
}