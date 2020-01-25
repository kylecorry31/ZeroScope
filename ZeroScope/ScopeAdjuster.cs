using System;

namespace ZeroScope
{
    public class ScopeAdjuster : IScopeAdjuster
    {

        public ScopeAdjustment Calculate(ScopeInfo scope, ShotInfo shot)
        {
            var calculator = new MOACalculator();

            var horizontalMOA = calculator.Calculate(shot.ShootingDistance, shot.HorizontalBulletOffset);
            var verticalMOA = calculator.Calculate(shot.ShootingDistance, shot.VerticalBulletOffset);

            var horizontalClicks = Math.Round(horizontalMOA / scope.HorizontalMOAPerClick);
            var verticalClicks = Math.Round(verticalMOA / scope.VerticalMOAPerClick);

            var horizontalDirection = Direction.None;
            if (horizontalClicks < 0)
            {
                horizontalDirection = Direction.Right;
            }
            else if (horizontalClicks > 0)
            {
                horizontalDirection = Direction.Left;
            }

            var verticalDirection = Direction.None;
            if (verticalClicks < 0)
            {
                verticalDirection = Direction.Up;
            }
            else if (verticalClicks > 0)
            {
                verticalDirection = Direction.Down;
            }

            return new ScopeAdjustment
            {
                HorizontalClicks = horizontalClicks,
                HorizontalDirection = horizontalDirection,
                VerticalClicks = verticalClicks,
                VerticalDirection = verticalDirection
            };

        }
    }
}
