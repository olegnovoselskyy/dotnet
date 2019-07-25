using System;

namespace Collections
{
    public enum Player { Empty = 0, X, O}

    public struct Square
    {
        public Player Owner { get; }

        public Square(Player owner)
        {
            this.Owner = owner;
        }

        public override string ToString()
        {
            switch (Owner)
            {
                case Player.Empty:
                    return ".";
                case Player.X:
                    return "X";
                case Player.O:
                    return "O";
                default:
                    throw new Exception("Invalid State");
            }
        }
    }
}
