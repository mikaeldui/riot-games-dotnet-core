using System.Collections;

namespace RiotGames
{
    public interface IRiotGamesReadOnlyCollection<T> : IReadOnlyCollection<T>, IRiotGamesEnumerable<T>, IRiotGamesEnumerable, IRiotGamesObject, IEnumerable<T>, IEnumerable
    {
    }
}
