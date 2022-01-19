using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace RiotGames
{
    /// <summary>
    /// An exception that implements <see cref="IRiotGamesException"/>.
    /// </summary>
    public class RiotGamesException : Exception, IRiotGamesException, IRiotGamesObject
    {
        public RiotGamesException()
        {
        }

        public RiotGamesException(string message) : base(message)
        {
        }

        public RiotGamesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RiotGamesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
