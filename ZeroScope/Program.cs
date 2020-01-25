using System;
using ZeroScope.UI;

namespace ZeroScope
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shotInfoRetriever = new ConsoleShotInfoRetriever();
            var scopeInfoRetriever = new ConsoleScopeInfoRetriever();

            var shot = shotInfoRetriever.GetShotInfo();
            var scope = scopeInfoRetriever.GetScopeInfo();

            IScopeAdjuster scopeAdjuster = new ScopeAdjuster();

            var adjustment = scopeAdjuster.Calculate(scope, shot);

            if (adjustment.VerticalDirection != Direction.None)
            {
                Console.WriteLine($"Adjustment recommended: { Math.Abs(adjustment.VerticalClicks) } clicks { adjustment.VerticalDirection.ToString().ToLower() }");
            }

            if (adjustment.HorizontalDirection != Direction.None)
            {
                Console.WriteLine($"Adjustment recommended: { Math.Abs(adjustment.HorizontalClicks) } clicks { adjustment.HorizontalDirection.ToString().ToLower() }");
            }

            if (adjustment.VerticalDirection == Direction.None && adjustment.HorizontalDirection == Direction.None)
            {
                Console.WriteLine("No adjustment recommended");
            }

        }
    }
}
