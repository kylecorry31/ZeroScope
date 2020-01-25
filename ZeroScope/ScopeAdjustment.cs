using System;

namespace ZeroScope
{
    public class ScopeAdjustment
    {

        public decimal HorizontalClicks { get; set; }

        public Direction HorizontalDirection { get; set; }

        public decimal VerticalClicks { get; set; }

        public Direction VerticalDirection { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ScopeAdjustment adjustment &&
                   HorizontalClicks == adjustment.HorizontalClicks &&
                   HorizontalDirection == adjustment.HorizontalDirection &&
                   VerticalClicks == adjustment.VerticalClicks &&
                   VerticalDirection == adjustment.VerticalDirection;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(HorizontalClicks, HorizontalDirection, VerticalClicks, VerticalDirection);
        }

        public override string ToString()
        {
            return $"Scope adjustment {HorizontalClicks} {HorizontalDirection}, {VerticalClicks} {VerticalDirection}";
        }
    }
}
