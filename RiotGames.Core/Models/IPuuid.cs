namespace RiotGames
{
    /// <summary>
    /// Not to be confused with <see cref="IEncryptedPuuid"/>.
    /// </summary>
    public interface IPuuid : IRiotGamesObject
    {
        public string Puuid { get; set; }
    }
}
