namespace ZeroScope
{
    public interface IScopeAdjuster
    {

        /// <summary>
        /// Calculate the scope adjustment
        /// </summary>
        /// <param name="scope">The scope information</param>
        /// <param name="shot">The shot information</param>
        /// <returns>The scope adjustment</returns>
        ScopeAdjustment Calculate(ScopeInfo scope, ShotInfo shot);

    }
}
