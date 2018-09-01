namespace Game.Internal
{
    struct Position
    {
        public Position(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public static Distance operator -(Position op1, Position op2)
        {
            return new Distance(op1.X - op2.X, op1.Y - op2.Y);
        }
    }
}
