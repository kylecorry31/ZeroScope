namespace ZeroScope
{
    public interface IScopeAdjuster
    {

        ScopeAdjustment Calculate(ScopeInfo scope, ShotInfo shot);

    }
}
