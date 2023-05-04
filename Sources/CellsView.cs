using System;
using System.Collections.Generic;


namespace Napilnik.Sources
{
    public class CellsView
    {
        public void ShowProductCells(IReadOnlyList<IReadOnlyCell> cells)
        {
            if(cells == null) 
                throw new ArgumentNullException(nameof(cells));

            foreach (var cell in cells)
            {
                Console.WriteLine(cell.Good.Name + "|" + cell.Count);
            }
        }
    }
}
