using System;

namespace OpenGame
{
    public class Player
    {
        public string Username { get; set; }
        public Guid GUID { get; }

        public Player(string username)
        {
            Username = username;
            GUID = Guid.NewGuid();
        }
    }
}