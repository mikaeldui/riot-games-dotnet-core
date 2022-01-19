namespace RiotGames
{
    public interface IRiotGamesDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IRiotGamesCollection<KeyValuePair<TKey, TValue>>, IRiotGamesEnumerable<KeyValuePair<TKey, TValue>>, IRiotGamesEnumerable, IRiotGamesObject
    {
    }
}
