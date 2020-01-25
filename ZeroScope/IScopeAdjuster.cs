namespace ZeroScope
{
    public interface IScopeAdjuster
    {

        decimal Calculate(decimal distanceToTarget, decimal distanceFromCenter);

    }
}
