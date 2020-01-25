namespace ZeroScope
{
    public class MOACalculator
    {

        private static readonly decimal REFERENCE_DISTANCE = 100M;
        private static readonly decimal REFERENCE_MOA = 1.047M;

        public decimal Calculate(decimal shootingDistance, decimal bulletOffset)
        {
            var inchesPerMOA = (shootingDistance / REFERENCE_DISTANCE) * REFERENCE_MOA;
            return bulletOffset / inchesPerMOA;
        }
    }
}
