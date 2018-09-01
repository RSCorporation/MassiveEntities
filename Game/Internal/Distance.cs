using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Internal
{
    struct Distance
    {
        public Distance(int dX, int dY) : this()
        {
            this.dX = dX;
            this.dY = dY;
        }

        public int dX { get; set; }
        public int dY { get; set; }
        public double GeometricalDistance { get { return Math.Sqrt(dX * dX + dY * dY); } }
        public static Distance operator - (Distance op)
        {
            return new Distance(-op.dX, -op.dY);
        }
        public static Distance operator + (Distance op1, Distance op2)
        {
            return new Distance(op1.dX + op2.dX, op1.dY + op2.dY);
        }
        public static Position operator + (Position pos, Distance dist)
        {
            return new Position(pos.X + dist.dX, pos.Y + dist.dY);
        }
        public static Distance operator - (Distance op1, Distance op2)
        {
            return new Distance(op1.dX - op2.dX, op1.dY - op2.dY);
        }
        public static Position operator - (Position pos, Distance dist)
        {
            return new Position(pos.X - dist.dX, pos.Y - dist.dY);
        }
    }
}
