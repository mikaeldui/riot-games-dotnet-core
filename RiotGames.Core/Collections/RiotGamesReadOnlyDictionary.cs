using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace RiotGames
{
    /// <summary>
    /// A genertic read-only dictionary that support JSON serialization and implements <see cref="IRiotGamesObject"/>.
    /// </summary>
    [JsonReadOnlyDictionary, DebuggerDisplay("Count = {Count}")]
    public class RiotGamesReadOnlyDictionary<TKey, TValue> : ReadOnlyDictionary<TKey, TValue>, IRiotGamesReadOnlyDictionary<TKey, TValue>, IRiotGamesEnumerable<KeyValuePair<TKey, TValue>>, IRiotGamesDictionary<TKey, TValue>, IRiotGamesCollection<KeyValuePair<TKey, TValue>>, IRiotGamesEnumerable, IRiotGamesObject
        where TKey : notnull
    {
        public RiotGamesReadOnlyDictionary(IDictionary<TKey, TValue> dictionary) : base(dictionary)
        {
        }
    }
}
