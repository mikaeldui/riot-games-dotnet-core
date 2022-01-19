namespace RiotGames
{
    /// <summary>
    /// Not to be confused with <see cref="IAccountId"/>. See https://developer.riotgames.com/apis#summoner-v4/GET_getBySummonerName.
    /// </summary>
    public interface IEncryptedAccountId : IRiotGamesObject
    {
        public string EncryptedAccountId { get; set; }
    }
}
