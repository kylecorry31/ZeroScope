namespace ZeroScope
{
    public class ReferenceMOACalculator : IMOACalculator
    {

        private static readonly decimal REFERENCE_DISTANCE = 100M;
        private static readonly decimal REFERENCE_MOA = 1.047M;

        public decimal Calculate(decimal distanceToTarget, decimal distanceFromCenter)
        {
            var inchesPerMOA = (distanceToTarget / REFERENCE_DISTANCE) * REFERENCE_MOA;
            return distanceFromCenter / inchesPerMOA;
        }
    }
}
