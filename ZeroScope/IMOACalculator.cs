namespace ZeroScope
{
    public interface IMOACalculator
    {

        /// <summary>
        /// Calculates MOA
        /// </summary>
        /// <param name="distanceToTarget">The distance to the target in yards</param>
        /// <param name="distanceFromCenter">The shot's distance from the center of the target in inches</param>
        /// <returns>The MOA</returns>
        decimal Calculate(decimal distanceToTarget, decimal distanceFromCenter);

    }
}
