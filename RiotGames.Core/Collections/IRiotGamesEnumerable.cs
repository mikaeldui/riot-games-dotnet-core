using System.Collections;

namespace RiotGames
{
    public interface IRiotGamesEnumerable : IEnumerable, IRiotGamesObject
    {
    }

    public interface IRiotGamesEnumerable<out T> : IEnumerable<T>, IRiotGamesEnumerable, IRiotGamesObject
    {
    }
}
