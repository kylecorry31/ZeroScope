using System;

namespace ZeroScope
{
    public class ScopeAdjuster : IScopeAdjuster
    {

        private readonly IMOACalculator MOACalculator;
        private readonly IMOAToClickConverter ClickConverter;

        public ScopeAdjuster(IMOACalculator moaCalculator, IMOAToClickConverter clickConverter)
        {
            MOACalculator = moaCalculator;
            ClickConverter = clickConverter;
        }

        public decimal Calculate(decimal distanceToTarget, decimal distanceFromCenter)
        {
            var shotMOA = MOACalculator.Calculate(distanceToTarget, distanceFromCenter);
            return ClickConverter.Convert(shotMOA);
        }
    }
}
