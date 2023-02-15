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
    
    public enum Result
    {
        Checkmate, // Win By Checkmate
        Resignation, // Win By Resignation
        WinOnTime, // Win By Time
        Forfeit, // Win By Forfeit
        Draw, // Draw
        Stalemate, // Draw By Stalemate
        Dead, // Draw By Dead Position
        Repetition, // Draw By Threefold Repetition
        FiftyMove, // Draw By Fifty Move Rule
        DrawOnTime, // Draw By Time
    }
    
    public enum Termination
    {
        Abandoned,
        Adjudication,
        Death, // How TF Does This Happen???
        Emergency,
        Normal,
        Infraction,
        TimeForfeit,
    }
}