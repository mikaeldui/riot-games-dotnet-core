using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace RiotGames
{
    /// <summary>
    /// A generic read-only collection that support JSON serialization.
    /// </summary>
    [JsonReadOnlyCollection, DebuggerDisplay("Count = {Count}")]
    public class RiotGamesReadOnlyCollection<T> : ReadOnlyCollection<T>, IRiotGamesReadOnlyCollection<T>, IRiotGamesCollection<T>, IRiotGamesObject
    {
        public RiotGamesReadOnlyCollection(IList<T> list) : base(list)
        {
        }
    }
}
