using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using UnityEngine;

namespace PlayersTimeSaver
{
    public class PlayerTimeComponent : UnturnedPlayerComponent
    {
        private float _connectedTime;



        private float _totalPlayingTime;
        public float TotalPlayingTime => _totalPlayingTime + CurrentSessionPlayingTime;


        private float _lastSessionPlayingTime;
        public float LastSessionPlayingTime => _lastSessionPlayingTime;


        private DateTime _dateFirstConnection;
        public DateTime DateFirstConnection => _dateFirstConnection;

        
        private DateTime _dateLastConnection;
        public DateTime DateLastConnection => _dateLastConnection;


        public float CurrentSessionPlayingTime => Time.realtimeSinceStartup - _connectedTime;
        private DateTime _dateCurrentSessionConnection;
        public DateTime DateCurrentSessionConnection => _dateCurrentSessionConnection;





        private void Start()
        {
            _connectedTime = Time.realtimeSinceStartup;
            _dateCurrentSessionConnection = DateTime.Now;



            if (PlayerSavedata.fileExists(Player.Player.channel.owner.playerID, "/Player/Time.dat"))
            {
                Data data = PlayerSavedata.readData(Player.Player.channel.owner.playerID, "/Player/Time.dat");
                
                _totalPlayingTime = data.readSingle("TotalPlayingTime", 0);
                _lastSessionPlayingTime = data.readSingle("LastSessionPlayingTime", 0);



                if (DateTime.TryParse(data.readString("DateFirstConnection"), out DateTime firstDate))
                    _dateFirstConnection = firstDate;
                else
                    _dateFirstConnection = DateTime.Now;




                if (DateTime.TryParse(data.readString("DateLastConnection"), out DateTime lastDate))
                    _dateLastConnection = lastDate;
                else
                    _dateLastConnection = DateTime.Now;
            }
            else
            {
                _dateFirstConnection = DateTime.Now;
                _dateLastConnection = DateTime.Now;
            }
        }

        private void OnDestroy()
        {
            if (PlayerSavedata.fileExists(Player.Player.channel.owner.playerID, "/Player/Time.dat"))
            {
                PlayerSavedata.deleteFile(Player.Player.channel.owner.playerID, "/Player/Time.dat");
            }

            Data data = new Data();
            data.writeSingle("TotalPlayingTime", TotalPlayingTime);
            data.writeSingle("LastSessionPlayingTime", CurrentSessionPlayingTime);
            data.writeString("DateFirstConnection", _dateFirstConnection.ToString());
            data.writeString("DateLastConnection", DateTime.Now.ToString());

            PlayerSavedata.writeData(Player.Player.channel.owner.playerID, "/Player/Time.dat", data);
        }
    }
}
