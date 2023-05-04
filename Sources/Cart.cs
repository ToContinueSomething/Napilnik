using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Napilnik.Sources
{
    public class Cart
    {
        private readonly Warehouse _warehouse;
        private List<Cell> _cells;

        public IReadOnlyList<IReadOnlyCell> Cells => _cells;

        public Cart(Warehouse warehouse)
        {
            if (warehouse == null)
                throw new ArgumentNullException(nameof(warehouse));

            _warehouse = warehouse;
            _cells = new List<Cell>();
        }

        public void Add(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            var newCell = new Cell(good, count);
            Cell foundCell = _cells.FirstOrDefault(cell => cell.Good == newCell.Good);

            if (foundCell == null)
                _cells.Add(new Cell(good, count));
            else
                foundCell.Merge(newCell);

            _warehouse.Fetch(good, count);
        }

        public Order Order()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var good in _cells)
            {
                stringBuilder.Append(good.Good.Name);
                stringBuilder.Append(", ");
            }

            return new Order(stringBuilder.ToString());
        }
    }
}
