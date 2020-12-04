using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;

namespace PlayersTimeSaver
{
    public static class PlayerExtension
    {
        public static float GetTotalPlayingTimeInSeconds(this Player player)
        {
            return player?.GetComponent<PlayerTimeComponent>()?.TotalPlayingTime ?? 0;
        }
        public static float GetTotalPlayingTimeInSeconds(this UnturnedPlayer player)
        {
            return GetTotalPlayingTimeInSeconds(player?.Player);
        }
        public static float GetTotalPlayingTimeInSeconds(this CSteamID steamID)
        {
            return GetTotalPlayingTimeInSeconds(UnturnedPlayer.FromCSteamID(steamID));
        }


        public static float GetCurrentSessionPlayingTimeInSeconds(this Player player)
        {
            return player?.GetComponent<PlayerTimeComponent>()?.CurrentSessionPlayingTime ?? 0;
        }
        public static float GetCurrentSessionPlayingTimeInSeconds(this UnturnedPlayer player)
        {
            return GetCurrentSessionPlayingTimeInSeconds(player?.Player);
        }
        public static float GetCurrentSessionPlayingTimeInSeconds(this CSteamID steamID)
        {
            return GetCurrentSessionPlayingTimeInSeconds(UnturnedPlayer.FromCSteamID(steamID));
        }
    }
}
