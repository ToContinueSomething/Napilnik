using System;

namespace Napilnik.Sources
{
    public class Cell : IReadOnlyCell
    {
        public int Count { get; private set; }
        
        public Good Good { get; private set; }

        public Cell(Good good, int count)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));
            
            Good = good;
            Count = count;
        }

        public void Merge(Cell newCell)
        {
            if (newCell.Good != Good)
                throw new InvalidOperationException();

            Count += newCell.Count;
        }

        internal void Fetch(Cell newCell)
        {
            if (newCell.Good != Good)
                throw new InvalidOperationException();

            if (Count < newCell.Count)
                throw new ArgumentOutOfRangeException(nameof(newCell.Count));

            Count -= newCell.Count;
        }
    }
}