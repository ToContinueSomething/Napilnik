using System;
using System.Collections.Generic;
using System.Linq;

namespace Napilnik.Sources
{
    public class Warehouse : IReadOnlyStorage
    {
        private List<Cell> _cells;

        public IReadOnlyList<IReadOnlyCell> Cells => _cells;

        public Warehouse()
        {
            _cells = new List<Cell>();
        }

        public void Delive(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            var newCell = new Cell(good, count);
            Cell foundCell = _cells.FirstOrDefault(cell => cell.Good == newCell.Good);

            if (foundCell == null)
                _cells.Add(newCell);
            else
                foundCell.Merge(newCell);
        }

        public void Fetch(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            var newCell = new Cell(good, count);
            Cell foundCell = _cells.FirstOrDefault(cell => cell.Good == newCell.Good);

            if (foundCell == null)
                throw new InvalidOperationException();

            foundCell.Fetch(newCell);
        }
    }
}