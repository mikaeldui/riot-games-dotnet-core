namespace RiotGames
{
    /// <summary>
    /// Not to be confused with <see cref="IPuuid"/>. See https://developer.riotgames.com/apis#summoner-v4/GET_getBySummonerName.
    /// </summary>
    public interface IEncryptedPuuid : IRiotGamesObject
    {
        public string EncryptedPuuid { get; set; }
    }
}
