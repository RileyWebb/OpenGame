using System;
using System.Collections.Generic;
using OpenChess;
using OpenGame;

namespace OpenGameAPI
{
    public static class GameManager
    {
        public static Dictionary<Guid, Game?> Games;

        static GameManager()
        {
            Games = new Dictionary<Guid, Game?>();

            var a = new ChessGame();
            Games.Add(a.GUID, a);
        }
    }
}