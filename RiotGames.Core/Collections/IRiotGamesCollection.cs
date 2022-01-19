using System.Collections;

namespace RiotGames
{
    public interface IRiotGamesCollection<T> : ICollection<T>, IRiotGamesEnumerable<T>, IRiotGamesEnumerable,  IRiotGamesObject, IEnumerable<T>, IEnumerable
    {
    }
}
