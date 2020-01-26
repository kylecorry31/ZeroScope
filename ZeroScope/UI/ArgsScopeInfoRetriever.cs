using System;

namespace ZeroScope.UI
{
    public class ArgsScopeInfoRetriever : IScopeInfoRetriever
    {

        private const int VERTICAL_MOA_PER_CLICK_IDX = 4;
        private const int HORIZONTAL_MOA_PER_CLICK_IDX = 3;

        private string[] args;

        public ArgsScopeInfoRetriever(string[] args)
        {
            if (args == null || args.Length < VERTICAL_MOA_PER_CLICK_IDX + 1) throw new Exception("Invalid args");
            this.args = args;
        }

        public ScopeInfo GetScopeInfo()
        {
            var verticalClicks = Decimal.Parse(args[VERTICAL_MOA_PER_CLICK_IDX]);
            var horizontalClicks = Decimal.Parse(args[HORIZONTAL_MOA_PER_CLICK_IDX]);

            return new ScopeInfo
            {
                VerticalMOAPerClick = verticalClicks,
                HorizontalMOAPerClick = horizontalClicks
            };
        }
    }
}
