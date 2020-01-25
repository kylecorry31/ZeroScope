using System;

namespace ZeroScope.UI
{
    public class ConsoleShotInfoRetriever : IShotInfoRetriever
    {
        public ShotInfo GetShotInfo()
        {
            var shootingDistance = GetDecimalValue("Enter target distance in yards: ");

            var verticalOffset = GetDecimalValue("Enter the bullet impact's vertical offset from target center in inches (below is negative): ");

            var horizontalOffset = GetDecimalValue("Enter the bullet impact's horizontal offset from target center in inches (left is negative): ");

            return new ShotInfo
            {
                ShootingDistance = shootingDistance,
                VerticalBulletOffset = verticalOffset,
                HorizontalBulletOffset = horizontalOffset
            };
        }

        private decimal GetDecimalValue(string prompt)
        {
            Console.Write(prompt);
            var value = Decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            return value;
        }

    }
}
