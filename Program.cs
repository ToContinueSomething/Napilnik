using Napilnik.Sources;

namespace Napilnik
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pathfinder pathfinder = new Pathfinder(new FileLogWritter());
            Pathfinder pathfinder2 = new Pathfinder(new ConsoleLogWritter());
            Pathfinder pathfinder3 = new Pathfinder(new SecureConsoleLogWritter(new FileLogWritter()));
            Pathfinder pathfinder4 = new Pathfinder(new SecureConsoleLogWritter(new ConsoleLogWritter()));
            Pathfinder pathfinder5 = new Pathfinder(new ChainOfLogWritter(new ILogger[] { new ConsoleLogWritter(),
                new SecureConsoleLogWritter(new FileLogWritter()) }));

            pathfinder.Find("@");
            pathfinder2.Find("#");
            pathfinder3.Find("$");
            pathfinder4.Find("()");
            pathfinder5.Find("&");
        }
    }
}