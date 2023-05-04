using System.Collections.Generic;

namespace Napilnik.Sources
{
    public interface IReadOnlyStorage
    {
       IReadOnlyList<IReadOnlyCell> Cells { get; }
    }
}
