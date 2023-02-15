using OpenGame;

namespace OpenChess
{
    public class ChessGame : Game
    {
        public Player? White { get; private set; }
        public Player? Black { get; private set; }

        public ChessGame(Player white = null, Player black = null)
        {
            White = white;
            Black = black;
        }
    }

    public enum GameState
    {

        Ongoing,
        Complete,
    }
    
    public enum GameResult
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
    
    public enum GameTermination
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