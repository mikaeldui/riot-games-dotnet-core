namespace RiotGames
{
    public interface IRiotGamesReadOnlyDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>, IRiotGamesEnumerable<KeyValuePair<TKey, TValue>>, IRiotGamesEnumerable, IRiotGamesCollection<KeyValuePair<TKey, TValue>>, IRiotGamesObject
    {
    }
}
