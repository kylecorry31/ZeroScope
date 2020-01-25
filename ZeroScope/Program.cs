using System;

namespace ZeroScope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter target distance in yards: ");
            var distanceToTarget = Decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the shot's distance from center in inches: ");
            var distanceFromCenter = Decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the scope's MOA per click: ");
            var scopeMOAPerClick = Decimal.Parse(Console.ReadLine());
            Console.WriteLine();


            IMOACalculator moaCalculator = new ReferenceMOACalculator();
            IMOAToClickConverter clickConverter = new ScopeMOAToClickConverter(scopeMOAPerClick);
            IScopeAdjuster scopeAdjuster = new ScopeAdjuster(moaCalculator, clickConverter);

            var shotMOA = moaCalculator.Calculate(distanceToTarget, distanceFromCenter);
            var scopeAdjustment = scopeAdjuster.Calculate(distanceToTarget, distanceFromCenter);

            Console.WriteLine($"Shot: { Math.Round(shotMOA, 2) } MOA");

            if (scopeAdjustment != 0.0M)
            {
                Console.WriteLine($"Adjustment recommended: { Math.Abs(scopeAdjustment) } clicks in the opposite direction as the shot.");
            } 
            else
            {
                Console.WriteLine("No adjustment recommended");
            }

        }
    }
}
