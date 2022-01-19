namespace RiotGames
{
    /// <summary>
    /// Not to be confused with <see cref="ISummonerId"/>. See https://developer.riotgames.com/apis#summoner-v4/GET_getBySummonerName.
    /// </summary>
    public interface IEncryptedSummonerId : IRiotGamesObject
    {
        public string EncryptedSummonerId { get; set; }
    }
}
