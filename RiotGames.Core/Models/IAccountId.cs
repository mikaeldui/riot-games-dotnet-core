namespace RiotGames
{
    /// <summary>
    /// not to be confused with <see cref="IEncryptedAccountId"/>.
    /// </summary>
    public interface IAccountId : IRiotGamesObject
    {
        public long AccountId { get; set; }
    }
}
