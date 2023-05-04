namespace Napilnik.Sources
{
    public interface IReadOnlyCell
    {
        int Count { get; }

        Good Good { get; }
    }
}