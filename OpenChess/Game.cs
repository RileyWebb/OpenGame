using OpenGame;

namespace OpenChess
{
    public class Game
    {
        public Player White { get; private set; }
        public Player Black { get; private set; }

        public Game(Player white, Player black)
        {
            White = white;
            Black = black;
        }
    }

    public enum GameState
    {
        Ongoing
    }
}