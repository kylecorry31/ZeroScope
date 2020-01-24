namespace ZeroScope
{
    public interface IMOAToClickConverter
    {

        /// <summary>
        /// Converts a MOA into clicks
        /// </summary>
        /// <param name="moa">The MOA</param>
        /// <returns>The MOA in clicks</returns>
        decimal Convert(decimal moa);

    }
}
