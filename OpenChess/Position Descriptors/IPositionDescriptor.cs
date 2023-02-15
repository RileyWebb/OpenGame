using OpenGame;

namespace OpenChess.PositionDescriptors
{
    public abstract class IPositionDescriptor
    {
        public IPositionDescriptor(string input)
        {
            
        }

        public abstract Game Create(Player white, Player black);
    }
}