namespace RiotGames
{
    /// <summary>
    /// Not to be confused with <see cref="IEncryptedSummonerId"/>.
    /// </summary>
    public interface ISummonerId : IRiotGamesObject
    {
        public long SummonerId { get; set; }
    }
}
