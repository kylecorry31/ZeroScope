using System;

namespace ZeroScope.UI
{
    public class ConsoleScopeInfoRetriever : IScopeInfoRetriever
    {
        public ScopeInfo GetScopeInfo()
        {
            var horizontalMOA = GetDecimalValue("Enter the scope's horizontal MOA per click: ");
            var verticalMOA = GetDecimalValue("Enter the scope's vertical MOA per click: ");

            return new ScopeInfo
            {
                HorizontalMOAPerClick = horizontalMOA,
                VerticalMOAPerClick = verticalMOA
            };
        }

        private decimal GetDecimalValue(string prompt)
        {
            Console.Write(prompt);
            var value = Decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            return value;
        }
    }
}
