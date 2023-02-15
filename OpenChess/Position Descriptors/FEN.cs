using OpenGame;

namespace OpenChess.PositionDescriptors
{
    public class FEN : IPositionDescriptor
    {
        public FEN(string input) : base(input)
        {
            
        }
        
        public override ChessGame Create(Player white, Player black)
        {
            return new ChessGame(white, black);
        }
    }
}