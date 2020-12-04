using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using System;

namespace PlayersTimeSaver
{
    public class Plugin : RocketPlugin
    {
        protected override void Load()
        {
            U.Events.OnPlayerDisconnected += onPlayerDisconnected;
        }
        protected override void Unload()
        {
            U.Events.OnPlayerDisconnected -= onPlayerDisconnected;
        }

        
        private void onPlayerDisconnected(UnturnedPlayer player)
        {
            Rocket.Core.Logging.Logger.Log($"{player.CharacterName} played: {player.GetCurrentSessionPlayingTimeInSeconds()} seconds", ConsoleColor.White);
        }
    }
}
