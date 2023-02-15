using System;

namespace OpenGame
{
    public abstract class Game
    {
        public Guid GUID { get; private set; }

        public Game()
        {
            GUID = Guid.NewGuid();
        }
    }
}