using OpenGame;

namespace OpenChess.PositionDescriptors
{
    public class FEN : IPositionDescriptor
    {
        public FEN(string input) : base(input)
        {
            
        }
        
        public override Game Create(Player white, Player black)
        {
            return new Game(white, black);
        }
    }
}